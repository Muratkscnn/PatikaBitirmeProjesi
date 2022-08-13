using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityConfig
{
    public class ApartmentInformationConfig : IEntityTypeConfiguration<ApartmentInformation>
    {
        public void Configure(EntityTypeBuilder<ApartmentInformation> builder)
        {
            builder.HasData(
                new ApartmentInformation() { ApartmentInformationId=1,BlockNo="A",ApartmentType="3+1",Floor=1,ApartmentNo=1,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=2,BlockNo="A",ApartmentType="3+1",Floor=1,ApartmentNo=2,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=3,BlockNo="A",ApartmentType="3+1",Floor=2,ApartmentNo=3,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=4,BlockNo="A",ApartmentType="3+1",Floor=2,ApartmentNo=4,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=5,BlockNo="A",ApartmentType="3+1",Floor=3,ApartmentNo=5,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=6,BlockNo="A",ApartmentType="3+1",Floor=3,ApartmentNo=6,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=7,BlockNo="A",ApartmentType="3+1",Floor=4,ApartmentNo=7,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=8,BlockNo="A",ApartmentType="3+1",Floor=4,ApartmentNo=8,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=9,BlockNo="A",ApartmentType="3+1",Floor=5,ApartmentNo=9,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=10,BlockNo="A",ApartmentType="3+1",Floor=5,ApartmentNo=10,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=11,BlockNo="B",ApartmentType="4+1",Floor=1,ApartmentNo=1,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=12,BlockNo="B",ApartmentType="4+1",Floor=1,ApartmentNo=2,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=13,BlockNo="B",ApartmentType="4+1",Floor=2,ApartmentNo=3,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=14,BlockNo="B",ApartmentType="4+1",Floor=2,ApartmentNo=4,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=15,BlockNo="B",ApartmentType="4+1",Floor=3,ApartmentNo=5,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=16,BlockNo="B",ApartmentType="4+1",Floor=3,ApartmentNo=6,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=17,BlockNo="B",ApartmentType="4+1",Floor=4,ApartmentNo=7,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=18,BlockNo="B",ApartmentType="4+1",Floor=4,ApartmentNo=8,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=19,BlockNo="B",ApartmentType="4+1",Floor=5,ApartmentNo=9,AppUserId=null},
                new ApartmentInformation() { ApartmentInformationId=20,BlockNo="B",ApartmentType="4+1",Floor=5,ApartmentNo=10,AppUserId=null}
                );
        }
    }
}
