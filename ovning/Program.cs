// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data.Common;

namespace Ovning1
{

    public class Program
    {

        private string empName;
        private string empPay;

        public void GetItemData()
        {
            ShowList();
        }

        private void ReadName()
        {
            Console.WriteLine("Enter Name: ");
            empName = Console.ReadLine();
        }

        private void ReadPay()
        {
            Console.WriteLine("Enter Pay: ");
            empPay = int.Parse(Console.ReadLine());
        }

        private void UpdateList()
        {
            int[] pay = [10];
            for (int i = 0; i < pay.Length; i++)
            {
                pay[i] = empPay;

            }

            string[] name = [""];
            for (int i = 0; i < pay.Length; i++)
            {
                name[i] = empName;

            }




      


        }

        private void ShowList()
        {
            Console.WriteLine(name[i], pay[i]);
        }

    }

}