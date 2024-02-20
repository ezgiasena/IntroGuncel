using IntroGuncel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroGuncel.DataAccess.Abstracts;

public interface ICourseDal //interface arayuz ya da ssablon demek sablon imzalardan olusur.
{
    List<Course> GetAll();
    void Add(Course course);

}
