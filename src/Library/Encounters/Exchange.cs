using System;
using System.Collections.Generic;

namespace Library
{
    public class Exchange : Encounter
    {
        public Heroes giver { get ; set ;}
        public Heroes receiver { get ; set ;}
        public List<IItems> items { get ; set ;}
        public Exchange(Heroes giver, Heroes receiver, List<IItems> items)
        {
            this.reporter = new ConsoleReporter();
            this.giver = giver;
            this.receiver = receiver;
            this.items = items;
        }
        public void DoEncounter()
        {
            this.reporter.ReportExchangeSetup(this.giver, this.receiver);
            foreach (IItems item in this.items)
            {
                this.giver.RemoveItem(item);
                this.receiver.AddItem(item);
                this.reporter.ReportExchange(this.giver, this.receiver, item);
            }
        }
    }
}