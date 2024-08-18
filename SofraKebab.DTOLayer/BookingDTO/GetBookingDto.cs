using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DTOLayer.BookingDTO
{
	public class GetBookingDto
	{
		public int BookingID { get; set; }
		public string Name { get; set; }
		public string PhoneNumber { get; set; }
		public string Mail { get; set; }
		public int PersonCount { get; set; }
		public DateTime BookingTime { get; set; }
	}
}
