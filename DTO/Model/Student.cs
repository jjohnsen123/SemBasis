using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public enum StudieType
    {
        Master,
        Bachelor,
        Enkeltfag,
        Videreuddannelse
    }

    public class Student
    {
        [Required]
        public String Name { get; set; }
        public DateTime StudieStart { get; set; }
        
        [Range(0, 100)]
        public int Age { get; set; }
        public StudieType StudieType { get; set; }
        public int StudieId { get; set; }

        public Student()
        {
        }

        public Student(string name, DateTime studieStart, int age, StudieType studieType, int studieId)
        {
            Name = name;
            StudieStart = studieStart;
            Age = age;
            StudieType = studieType;
            StudieId = studieId;
        }
    }
}
