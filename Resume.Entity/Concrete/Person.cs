﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class Person : BaseEntity
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string IdentityNumber { get; set; }
	public DateTime BirthDate { get; set; }
	public string ImageUrl { get; set; }
	public string Description { get; set; }
}
