﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DasBlog.Web.UI.Models.BlogViewModels
{
    public class PostViewModel
    {
		[StringLength(60)]
		public string Title { get; set; }

		[DataType(DataType.MultilineText)]
		public string Content { get; set; }

		[DataType(DataType.MultilineText)]
		public string Description { get; set; }

        public string Author { get; set; }

        public string PermaLink { get; set; }

        public string EntryId { get; set; }

        public IList<CategoryViewModel> Categories { get; set; }

		public IList<CategoryViewModel> AllCategories { get; set; }

		[Display(Name = "Allow Comments")]
		public bool AllowComments { get; set; }

		[Display(Name = "Is Public")]
		public bool IsPublic { get; set; }

		public bool Syndicated { get; set; }

		[Display(Name = "Date Created")]
		public DateTime CreatedDateTime { get; set; }

		[Display(Name = "Date Modified")]
		public DateTime ModifiedDateTime { get; set; }
	}
}
