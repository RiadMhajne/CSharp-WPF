﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollegeAPI.Models
{
    

    public class User
    {
        public enum Role { Teacher, Student }
        
        //key
        public int UserID { get; set; }
        
        public string? Name { get; set; }
        public string? userName { get; set; }
        public string? password { get; set; }
        public Role role { get; set; }

        //public ICollection<Course>? Courses { get; set; }
        //public ICollection<Grade>? Grades { get; set; }
    }


    public class Course
    {
        //key
        public int CourseID { get; set; }
        public int CourseNum { get; set; }
        public string? CourseName { get; set; }
        public int? TeacherID { get; set; }
        public string? Description { get; set; }

        //public User? Teacher { get; set; }
        //public ICollection<Task>? Tasks { get; set; }

    }

    public class Enrolment
    {
        public int EnrolmentID { get; set; }

        //key
        public int CourseNum { get; set; }
        //key
        public int UserID { get; set; }
    }

    public class Task
    {
        
        //key
        public int TaskNum { get; set; }
        //key
        public int CourseNum { get; set; }
        public string JsonFile { get; set; }
        public string RoleFile { get; set; }

        //public Course? Course { get; set; }


    }

    public class Grade
    {
        public int GradeID { get; set; }
        public int grade { get; set; }

        //key
        public int StudentID { get; set; }
        //key
        public int CourseNum { get; set; }
        //key
        public int TaskNum { get; set; }
        

        //public Task? Task { get; set; }
        //public User? Student { get; set; }

    }

    public class Average
    {
        public int StudentID { get; set; }
        public int courseNum { get; set; }
        public double average { get; set; }


    }

}
