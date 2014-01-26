﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Barometer.Models
{
    public class ProjectGroup
    {
        private int _id;
        private Project _project;
        private List<Student> _projectStudents;
        private Teacher _tutor;
        private string _classCode;

        public ProjectGroup(string classCode, Project project)
        {
            _classCode = classCode;
            _project = project;
            _projectStudents = new List<Student>();
        }

        public ProjectGroup(Project project, string group, Teacher tutor, List<Student> students)
        {
            _project = project;
            _classCode = group;
            _tutor = tutor;
            _projectStudents = students;
        }

        public ProjectGroup()
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ClassCode
        {
            get { return _classCode; }
            set { _classCode = value; }
        }
        


        public Teacher Tutor
        {
            get { return _tutor; }
            set { _tutor = value; }
        }
        

        public List<Student> ProjectStudents
        {
            get { return _projectStudents; }
            set { _projectStudents = value; }
        }
        

        public Project Project
        {
            get { return _project; }
            set { _project = value; }
        }
        
    }
}