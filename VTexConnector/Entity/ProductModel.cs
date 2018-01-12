﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTexConnector.Entity
{
    public class ProductModel
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? DepartmentId { get; set; }
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string LinkId { get; set; }
        public string RefId { get; set; }
        public bool? IsVisible { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string KeyWords { get; set; }
        public string Title { get; set; }
        public bool? IsActive { get; set; }
        public string TaxCode { get; set; }
        public string MetaTagDescription { get; set; }
        public int? SupplierId { get; set; }
        public bool ShowWithoutStock { get; set; }
        public List<int> ListStoreId { get; set; }
        public string AdWordsRemarketingCode { get; set; }
        public string LomadeeCampaignCode { get; set; }
    }
}
