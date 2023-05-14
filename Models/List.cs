namespace Todo_App.Models {
    public class List {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

        public List() { 
            this.Tasks = new List<Task>();
        }
    }
}
