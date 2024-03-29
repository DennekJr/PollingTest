﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace PollingSystemMVC.Models
{
	public class ApplicationUser : IdentityUser
	{
		public ICollection<PollQuestion>? Questions { get; set; } = null!;
		public ICollection<PollOption> Options { get; set; } = null!;
		public int CorrectOptionCount { get; set; } = 0;

		public string? Role { get; set; }

		public ApplicationUser()
		{
			Questions = new HashSet<PollQuestion>();
			Options = new HashSet<PollOption>();
		}
	}
}

