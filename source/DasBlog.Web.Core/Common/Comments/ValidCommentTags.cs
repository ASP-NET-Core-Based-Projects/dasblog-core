﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DasBlog.Core.Common.Comments
{
	public class ValidCommentTags
	{
		public List<Tag> Tag { get; set; }

		public bool IsValidTag(string tagName)
		{
			if (Tag.Count(s => s.TagName == tagName) == 0) return false;

			return Tag.Single(s => s.TagName == tagName) != null && Tag.Single(s => s.TagName == tagName).Allowed;
		}
	}
}