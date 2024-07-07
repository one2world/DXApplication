using DevExpress.Mvvm.Gantt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication2.Models
{
    public class Customer : GanttTask
    {
        //public int Id { get; set; }
        //public int ParentId { get; set; }
        //public string Name { get; set; }
        public string City { get; set; }
        public int Visits { get; set; }
        public DateTime? Birthday { get; set; }
        //public DateTime? StartDate { get; set; }
        //public DateTime? FinishDate { get; set; }
    }
    internal class CustomerDataModel
    {
        public ObservableCollection<Customer> GetCustomers()
        {
            ObservableCollection<Customer> people = new ObservableCollection<Customer>();
            people.Add(new Customer() { Id = 0, Name = "Gregory S. Price", City = "Hong Kong", Visits = 4, Birthday = new DateTime(1980, 1, 1) });
            people.Add(new Customer() {
                Id = 1,
                ParentId = 0,
                Name = "Irma R. Marshall", City = "Madrid", Visits = 2, Birthday = new DateTime(1966, 4, 15),
                StartDate = DateTime.Now.AddDays(-1),
                FinishDate = DateTime.Now.AddDays(6)
            });
            people.Add(new Customer() {
                Id = 2,
                ParentId = 0,
                Name = "John C. Powell", City = "Los Angeles", Visits = 6, Birthday = new DateTime(1982, 3, 11),
                StartDate = DateTime.Now.AddDays(-1),
                FinishDate = DateTime.Now.AddDays(2)
            });
            people.Add(new Customer() {
                Id = 3,
                ParentId = 0,
                Name = "Christian P. Laclair", City = "London", Visits = 11, Birthday = new DateTime(1977, 12, 5),
                StartDate = DateTime.Now.AddDays(2),
                FinishDate = DateTime.Now.AddDays(5)
            });
            people.Add(new Customer() {
                Id = 4,
                ParentId = 0,
                Name = "Karen J. Kelly", City = "Hong Kong", Visits = 8, Birthday = new DateTime(1956, 9, 5),
                StartDate = DateTime.Now.AddDays(2),
                FinishDate = DateTime.Now.AddDays(5)
            });
            people.Add(new Customer() {
                Id = 5,
                ParentId = 0,
                Name = "Brian C. Cowling", City = "Los Angeles", Visits = 5, Birthday = new DateTime(1990, 2, 27),
                StartDate = DateTime.Now.AddDays(6),
                FinishDate = DateTime.Now.AddDays(8),
            });
            people.Add(new Customer() {
                Id = 6,
                ParentId = 1,
                Name = "Thomas C. Dawson", City = "Madrid", Visits = 21, Birthday = new DateTime(1965, 5, 5),
                StartDate = DateTime.Now.AddDays(6),
                FinishDate = DateTime.Now.AddDays(9),
            });
            people.Add(new Customer() {
                Id = 7,
                ParentId = 0,
                Name = "Angel M. Wilson", City = "Los Angeles", Visits = 8, Birthday = new DateTime(1987, 11, 9),
                StartDate = DateTime.Now.AddDays(7),
                FinishDate = DateTime.Now.AddDays(9),
            });
            people.Add(new Customer() {
                Id = 8,
                ParentId = 2,
                Name = "Winston C. Smith", City = "London", Visits = 1, Birthday = new DateTime(1949, 6, 18),
                StartDate = DateTime.Now.AddDays(10),
                FinishDate = DateTime.Now.AddDays(11),
            });
            people.Add(new Customer() {
                Id = 9,
                ParentId = 0,
                Name = "Harold S. Brandes", City = "Bangkok", Visits = 3, Birthday = new DateTime(1989, 1, 8),
                StartDate = DateTime.Now.AddDays(9),
                FinishDate = DateTime.Now.AddDays(12),
            });
            people.Add(new Customer() {
                Id = 10,
                ParentId = 3,
                Name = "Michael S. Blevins", City = "Hong Kong", Visits = 4, Birthday = new DateTime(1972, 9, 14),
                StartDate = DateTime.Now.AddDays(10),
                FinishDate = DateTime.Now.AddDays(12),
            });
            people.Add(new Customer() {
                Id = 11,
                ParentId = 4,
                Name = "Jan K. Sisk", City = "Bangkok", Visits = 6, Birthday = new DateTime(1989, 5, 7),
                StartDate = DateTime.Now.AddDays(12),
                FinishDate = DateTime.Now.AddDays(14),
            });
            people.Add(new Customer() {
                Id = 12,
                ParentId = 0,
                Name = "Sidney L. Holder", City = "London", Visits = 19, Birthday = new DateTime(1971, 10, 3),
                StartDate = DateTime.Now.AddDays(13),
                FinishDate = DateTime.Now.AddDays(15),
            });

            // the "Release the new feature" task can begin only when the "Write the docs" task is complete
            people[4].PredecessorLinks.Add(new GanttPredecessorLink() { PredecessorTaskId = 2, LinkType = PredecessorLinkType.FinishToStart });
            // the "Release the new feature" task can begin only when the "Test the new feature" task is complete
            people[4].PredecessorLinks.Add(new GanttPredecessorLink() { PredecessorTaskId = 3, LinkType = PredecessorLinkType.FinishToStart });
            // the "Write the docs" task can begin only when the "Write the code" task is complete
            people[2].PredecessorLinks.Add(new GanttPredecessorLink() { PredecessorTaskId = 1, LinkType = PredecessorLinkType.FinishToStart });
            // the "Test the new feature" task can begin only when the "Write the code" task is complete
            people[3].PredecessorLinks.Add(new GanttPredecessorLink() { PredecessorTaskId = 1, LinkType = PredecessorLinkType.FinishToStart });
            return people;
        }
    }
}
