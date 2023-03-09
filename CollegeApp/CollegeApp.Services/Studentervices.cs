using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace CollegeApp.Services
{
    public string Constr { get; set; }
    public IConfiguration _configuration;
    public SqlConnection conn;
    public Studentervices(IConfiguration configuration)
    {
        _configuration = configuration;
        Constr = _configuration.
    }
}
