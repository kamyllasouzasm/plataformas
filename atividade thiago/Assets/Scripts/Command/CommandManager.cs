using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public List<ICommand> commands;

    public CommandManager()
    {
        commands = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        commands.Add(command);
    }

    public void DoCommand()
    {
        commands[^1].Do();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
