using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Inherence.RealEstate
{
    public abstract class RealEstate
    {
        string type, id;
        double width, height;

        public string Id { get => id; set => id = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public string Type { get => type; set => type = value; }

        public RealEstate()
        {
            Type = "";
            id = "";
            width = 0;
            height = 0;
        }
        public RealEstate(string type, string id, double width, double height)
        {
            this.type = type;
            this.id = id;
            this.width = width;
            this.height = height;
        }
        public abstract long getValue();
        public virtual double getAcreage()
        {
            return width * height;
        }
        public virtual void getInfor()
        {
            Console.WriteLine("Type:{0} Id:{1} Width:{2} Height:{3}", Type, Id, Width, Height);
        }
    }
    class Vacant : RealEstate
    {
        public Vacant() : base()
        { }
        public override long getValue()
        {
            return Convert.ToInt64(getAcreage() * 10000);
        }
    }
    class Shelter : RealEstate
    {
        int floor;
        public Shelter() : base()
        {
            floor = 0;
        }
        public Shelter(int floor) : base()
        {
            this.floor = floor;
        }

        public int Floor { get => floor; set => floor = value; }
        public override long getValue()
        {
            return Convert.ToInt64(getAcreage() * 10000 + floor * 10000);
        }
        public override void getInfor()
        {
            base.getInfor();
            Console.WriteLine("Floor:{0}", Floor);
        }
    }
    class Hotel : RealEstate, Tax
    {
        int star;
        public Hotel() : base()
        {
            star = 0;
        }
        public Hotel(int star) : base()
        {
            this.star = star;
        }

        public int Star { get => star; set => star = value; }
        public override long getValue()
        {
            return Convert.ToInt64(getAcreage() * 100000 + star * 50000) + tax();
        }
        public long tax()
        {
            return Convert.ToInt64(getAcreage() * 1000);
        }
        public override void getInfor()
        {
            base.getInfor(); Console.WriteLine("Star:{0}", Star);
        }
    }
    public class Villa : RealEstate, Tax
    {

        public Villa() : base()
        {
        }
        public override long getValue()
        {
            return Convert.ToInt64(getAcreage() * 400000) + tax();
        }
        public long tax()
        {
            return Convert.ToInt64(getAcreage() * 1000);
        }
    }
    public class RealEstateList
    {
        List<RealEstate> list = new List<RealEstate>();
        XmlDocument read = new XmlDocument();

        internal List<RealEstate> List { get => list; set => list = value; }
        public void Input(string file)
        {
            read.Load(file);
            XmlNodeList bdss = read.SelectNodes("/RealEstate/Vacant");
            foreach (XmlNode item in bdss)
            {
                Vacant tmp = new Vacant();
                tmp.Type = item["type"].InnerText;
                tmp.Id = item["id"].InnerText;
                tmp.Width = Convert.ToDouble(item["width"].InnerText);
                tmp.Height = Convert.ToDouble(item["height"].InnerText);
                list.Add(tmp);
            }
            bdss = read.SelectNodes("/RealEstate/Shelter");
            foreach (XmlNode item in bdss)
            {
                Shelter tmp = new Shelter();
                tmp.Type = item["type"].InnerText;
                tmp.Id = item["id"].InnerText;
                tmp.Width = Convert.ToDouble(item["width"].InnerText);
                tmp.Height = Convert.ToDouble(item["height"].InnerText);
                tmp.Floor = Convert.ToInt32(item["floor"].InnerText);
                list.Add(tmp);
            }
            bdss = read.SelectNodes("/RealEstate/Hotel");
            foreach (XmlNode item in bdss)
            {
                Hotel tmp = new Hotel();
                tmp.Type = item["type"].InnerText;
                tmp.Id = item["id"].InnerText;
                tmp.Width = Convert.ToDouble(item["width"].InnerText);
                tmp.Height = Convert.ToDouble(item["height"].InnerText);
                tmp.Star = Convert.ToInt32(item["star"].InnerText);
                list.Add(tmp);
            }
            bdss = read.SelectNodes("/RealEstate/Villa");
            foreach (XmlNode item in bdss)
            {
                Villa tmp = new Villa();
                tmp.Type = item["type"].InnerText;
                tmp.Id = item["id"].InnerText;
                tmp.Width = Convert.ToDouble(item["width"].InnerText);
                tmp.Height = Convert.ToDouble(item["height"].InnerText);
                list.Add(tmp);
            }
        }
        public void Output()
        {
            foreach (var item in list)
            {
                item.getInfor();
            }
        }
        public long getTotalValue()
        {
            long sum = 0;
            foreach (var item in list)
            {
                sum += item.getValue();
            }
            return sum;
        }

        public long getTotalTax()
        {
            long sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].Type.Equals("Villa") && !list[i].Type.Equals("Hotel"))
                {
                    continue;
                }
                sum += list[i].getValue();
            }
            return sum;
        }
    }

}
