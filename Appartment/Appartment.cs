using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flats
{
    internal class Flat
    {
        int numFlat;
        string ownerName;
        int numRooms;
        int familyMembers;
        int[] payments;

        public Flat(int numFlat, string ownerName, int numRooms, int familyMembers)
        {
            this.numFlat = numFlat;
            this.ownerName = ownerName;
            this.numRooms = numRooms;
            this.familyMembers = familyMembers;
            this.payments = new int[12];
            for (int i = 0; i < this.payments.Length; i++)
            {
                this.payments[i] = 0;
            }
        }
        public int GetNumFlat() => this.numFlat;
        public void SetNumFlat(int flat) => this.numFlat = flat;
        public string GetOwnerName() => this.ownerName;
        public void SetOwnerName(string name) => this.ownerName = name;
        public int CalculatePayment() => this.numRooms * 20 + this.familyMembers * 10;
        /// <summary>
        /// <paramref name="numMonth"/> is the index of the payment
        /// </summary>
        /// <param name="numMonth"></param>
        public void Pay(int numMonth) => this.payments[numMonth - 1] = this.CalculatePayment();
        public int Debt()
        {
            int count = 0;
            foreach (int payment in this.payments)
            {
                if (payment == 0) { count++; }
            }
            return count * CalculatePayment();
        }
    }
}
