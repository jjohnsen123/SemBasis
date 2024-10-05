using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson05.Models {
    public class ParkingTicketMachine {
        private int minutesPrKr = 3;

        private int[] coinsToInsert = {1, 2, 5, 10, 20};
        private int amountInserted;
        private DateTime timeNow;
       


        public int[] CoinsToInsert  { get { return coinsToInsert; } }



        
        //[ReadOnly(true)]
        //[UIHint("readonly")]
        [Display(Name = "Time now")]
        [DataType(DataType.Time)]
        public DateTime TimeNow { get { return timeNow; } }
        
        [Display(Name="Paid until")]
        [DataType(DataType.Time)]
        public DateTime PaidUntil { get { return timeNow.AddMinutes(minutesPrKr * amountInserted); } }

        [Display(Name = "Info display")]
        public string Info { get; set; }
       
        [HiddenInput(DisplayValue=false)]
        public int AmountInserted {
            get { return amountInserted; }
        }
        
        public ParkingTicketMachine() { 
            this.amountInserted = 0;
            timeNow = DateTime.Now;
            Info = "";
        }

        public void insertCoin(int kr) {
            amountInserted += kr;
        }

    }

    

}