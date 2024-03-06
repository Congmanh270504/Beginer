﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Beginer
{
    public class Student_Generic
    {
        List<Student> Student_List = new List<Student>();

        public List<Student> Student_List1 { get => Student_List; set => Student_List = value; }
        public void getGreater8()
        {
            Console.WriteLine("Danh sach cac sinnh vien co diem lon hon 8: ");

            foreach (var item in this.Student_List)
            {
                if (item.Point > 8)
                {
                    item.getInfor();
                }
            }
        }
        public void findStudentByName(string name)
        {
            foreach (var item in this.Student_List)
            {
                if (item.Name.ToString().ToLower().Equals(name.ToLower()))
                {
                    item.getInfor();
                }
            }
        }
        public void findStudentById(string id)
        {
            Console.WriteLine("Sinh vien can tim: ");
            foreach (var item in this.Student_List)
            {
                if (item.Id.ToString().ToLower().Equals(id.ToLower()))
                {
                    item.getInfor();
                }
            }
        }
        public void Add(Student student)
        {
            Student_List.Add(student);
        }
        public void xuatDS()
        {
            Console.WriteLine("Danh sach sinh vien: ");
            foreach (var item in this.Student_List)
            {
                Console.WriteLine("Student {0}:{1} {2} {3}", this.Student_List.IndexOf(item), item.Id, item.Name, item.Point);
            }
        }
    }
}
