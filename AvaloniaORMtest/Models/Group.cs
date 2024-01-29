using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace AvaloniaORMtest.Models;

public enum SecurityClearance
{
    Base,
    Mid,
    High
};

public class Group
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    private SecurityClearance _secClearance;
    public SecurityClearance SecClearance
    {
        get { return _secClearance; }
        set { _secClearance = value; }
    }
    public List<User> Users { get; set; }


    public Group()
    {
        
    }
    public Group(string groupName, SecurityClearance secClearance, List<User> users)
    {
        GroupName = groupName;
        secClearance = SecClearance;
        Users = users;
    }
}