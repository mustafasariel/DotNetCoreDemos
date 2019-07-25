using DotNetCoreDemos.Entities;
using System.Collections.Generic;

namespace DotNetCoreDemos.Models
{
    public class ViewModel
    {
        public List<Student> Students = new List<Student>();
        public List<Teacher> Teachers = new List<Teacher>();
    }
}