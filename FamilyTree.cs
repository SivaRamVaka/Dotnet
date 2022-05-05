using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FamilyTree
    {

        static void Main()
        {
            FamilyTree tree = new FamilyTree();
            tree.PrintFamilydetails("Sivaramakrishna");
        }
        public void PrintFamilydetails(string name)
        {
            Child objchaild=new Child();
            objchaild.ChildName1 = name;
            Familydetails(objchaild);

        }

        public void Familydetails(Child obj)
        {
            string result = $"Surename :{obj.Surname} \n GrandFater :{obj.GrandParentName1} ,GrandMother :{obj.GrandParentName2} \n"
                + $" Father :{obj.ParentName1} ,Mother :{obj.ParentName2} \n son :{obj.ChildName1} \n"
                + $"Location :{obj.Location} , City :{obj.City}";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }


    public class GrandParent
    {

        public string GrandParentName1 { get; set; } = "Govardhnarao";
        public string GrandParentName2 { get; set; } = "Janikamma";
        public string Location { get; set; } = "7-21,Agiripalli,Krishna,AP";

        public string Surname { get; set; } = "Vaka";
        public string City { get; set; } = "Agiripalli";

        //public GrandParent(string name1,string name2)
        //{
        //    this.GrandParentName1 = name1;
        //    this.GrandParentName2 = name2;
        //}

    }

    public class Parent:GrandParent
    {
        public string ParentName1 { get; set; } = "Srinivasarao";
        public string ParentName2 { get; set; } = "Kumari";
    }

    public class Child:Parent
    {
        public string ChildName1 { get; set; }
      
    }
}
