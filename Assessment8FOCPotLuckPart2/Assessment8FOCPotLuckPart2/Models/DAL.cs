using Dapper;
using Dapper.Contrib.Extensions;
using MySql.Data.MySqlClient;

namespace Assessment8FOCPotLuckPart2.Models
{
    public class DAL
    {
        public static MySqlConnection DB = new MySqlConnection("Server=127.0.0.1;Database=focpotluck;Uid=root;Pwd=QuickenROcketMortgage1111!; convert zero datetime=True");

        //CRUD Operations for TEAMMEMBER 

        //Read All 
        public static List<TeamMember> GetAllTeamMembers()
        {
            return DB.GetAll<TeamMember>().ToList();
        }

        //Read One 
        public static TeamMember GetOneTeamMember(int id)
        {
            return DB.Get<TeamMember>(id);
        }
        //Create 
        public static TeamMember InsertTeamMember(TeamMember member)
        {
            DB.Insert<TeamMember>(member);  
            return member;
        }

        //Edit d
        public static void UpdateTeamMember(TeamMember member)
        {
            DB.Update<TeamMember>(member);  
        }

        //Delete 
        public static void DeleteTeamMember(int id)
        {
            TeamMember member = new TeamMember();
            member.id = id; 
            DB.Delete<TeamMember>(member);
        }


        //CRUD Operations for DISH 

        //Read All 
        public static List<Dish> GetAllDishes()
        {
            return DB.GetAll<Dish>().ToList();
        }
        //Read One 
        public static Dish GetADish(int id)
        {
            return DB.Get<Dish>(id); 
        }
        //Create 
        public static Dish InsertDish (Dish dish)
        {
            DB.Insert<Dish>(dish);
            return dish; 
        }

        //Edit 
        public static void UpdateDish (Dish dish)
        {
            DB.Update<Dish>(dish);
        }

        //Delete 
        public static void DeleteDish (int id)
        {
            Dish newDish = new Dish();
            newDish.id = id;
            DB.Delete<Dish>(newDish); 
        }
    }
}
