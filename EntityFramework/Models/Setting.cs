﻿using System;
namespace EntityFramework.Models
{
	public class Setting :BaseEntity
	{
		public  string Address { get; set; }
		public  string Email { get; set; }
		public  string Phone { get; set; }
		public  string Name{ get; set; }
	}
}

