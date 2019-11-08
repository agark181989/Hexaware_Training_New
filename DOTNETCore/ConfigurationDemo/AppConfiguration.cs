using System;
namespace ConfigurationDemo
{
    public class AppConfiguration
    {
        public string CompanyName {get;set;}
        public string Location {get;set;}
        public int ParticipantCount {get;set;}        
        public ProjectDetails ProjectDetails {get; set;}
        public string PROCESSOR_ARCHITECTURE {get; set;}
        public string NUMBER_OF_PROCESSORS {get; set;}
    }

    public class ProjectDetails
    {
        public string Title {get;set;}
        public int Duration {get;set;}
        public string Status {get;set;}
    }    
}