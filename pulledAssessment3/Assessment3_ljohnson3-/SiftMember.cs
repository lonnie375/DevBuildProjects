using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3_ljohnson3
{
    public class SiftMember
    {
        //1. 5 SiftMember properties 
        public string name { get; set; }
        public DateTime anniversaryDate  { get; set; }
        public string jobTitle { get; set; }
        public string email { get; set; }
        public List<string> skills { get; set; }

        //2. Overloaded SiftMember constructor 
        public SiftMember(string _name, string _jobTitle, DateTime date,  string _email, List<string> _skills)
        {
            name = _name;
            anniversaryDate = date;
            jobTitle = _jobTitle;
            email = _email;
            skills = _skills;
        }

        public SiftMember()
        {

        }

        //3. Add skill method 
        public bool AddSkill(List<string> userSkills)
        {
            //Return true of no duplicates are found 
            if (userSkills.Count != userSkills.Distinct().Count())
            {
                return false;
            }
            return true; 
        }

        //4. Override ToString()
        public override string ToString()
        {
            return $"Name: {name} Job Title: {jobTitle}  Anniversary: {anniversaryDate}  Email: {email} Skills: {skills}"; 
        }
    }
}
