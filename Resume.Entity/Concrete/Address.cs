using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resume.Entity.Abstract;

namespace Resume.Entity.Concrete;
public class Address : BaseEntity
{
	public string District { get; set; }
	public string Street { get; set; }
	public byte BuildNumber { get; set; }
	public byte? ApartmentNumber { get; set; }
	public byte? FloorNumber { get; set; }
	public Guid TownId { get; set; }
	public Town Town { get; set; }
	public Guid CityId { get; set; }
	public City City { get; set; }
	public string? PostalCode { get; set; }
}
