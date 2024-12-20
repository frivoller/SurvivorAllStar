// BaseEntity.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurvivorProject.Model.Entity;
using System;

namespace SurvivorProject.Model.Entity
{
    public class BaseEntity  // Controller'dan inherit edilmesini kaldırdık
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

        protected BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            IsDeleted = false;
        }

        public void MarkAsDeleted()
        {
            IsDeleted = true;
            UpdateModifiedDate();
        }

        public void UpdateModifiedDate()
        {
            UpdatedDate = DateTime.UtcNow;
        }

        public void Restore()
        {
            IsDeleted = false;
            UpdateModifiedDate();
        }

        public override string ToString()
        {
            return $"Id: {Id}, CreatedDate: {CreatedDate}, UpdatedDate: {UpdatedDate?.ToString() ?? "N/A"}, IsDeleted: {IsDeleted}";
        }
    }
}

