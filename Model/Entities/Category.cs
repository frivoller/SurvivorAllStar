using System;
using System.Collections.Generic;

namespace SurvivorProject.Model.Entity
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Competitors> Competitors { get; set; }

        public int PopularityRank { get; set; }

        public string IconUrl { get; set; }

        public bool IsActive { get; private set; }

        public Category()
#pragma warning restore CS8618
        {
            Competitors = new List<Competitors>();
            IsActive = true;
            PopularityRank = 1; 

        public void Deactivate()
        {
            IsActive = false;
            UpdateModifiedDate();
        }

        public void Activate()
        {
            IsActive = true;
            UpdateModifiedDate();
        }

        private new void UpdateModifiedDate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, PopularityRank: {PopularityRank}, IsActive: {IsActive}, CompetitorsCount: {Competitors?.Count ?? 0}";
        }
    }
}