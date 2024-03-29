﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Persistence.Configuration.Entities
{
	public class LeaveTypeConfiguration : IEntityTypeConfiguration<LeaveType>
	{
		public void Configure(EntityTypeBuilder<LeaveType> builder)
		{
			builder.HasData(

				new LeaveType
				{
					Id = 1,
					DefaultDays = 10,
					Name = "Vacation"
				},
				new LeaveType
				{
					Id = 2,
					DefaultDays = 12,
					Name = "Sick"
				}


				);
		}
	}
}
