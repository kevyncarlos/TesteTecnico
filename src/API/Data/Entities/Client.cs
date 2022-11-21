namespace API.Data.Entities
{
    public class Client : EntityBase
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"'{nameof(Id)}: {Id} | {nameof(CreatedAt)}: {CreatedAt:g} | {nameof(UpdatedAt)}: {UpdatedAt:g} | {nameof(Name)}: {Name} | {nameof(BirthDate)}: {BirthDate:g} | {nameof(Address)}: {Address}'";
        }
    }
}
