﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofraKebab.DTOLayer.ContactDTO
{
	public class UpdateContactDto
	{
		public int ContactID { get; set; }
		public string Location { get; set; }
		public string PhoneNumber { get; set; }
		public string Mail { get; set; }
		public string FooterDesc { get; set; }
	}
}
