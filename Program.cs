using AppInterfaces;

ToDoList tdl = new ToDoList();
tdl.Add("Invite friends");
tdl.Add("Buy decorations");
tdl.Add("Party");
PasswordManager pm = new PasswordManager("iluvpie", true);

tdl.Display();
tdl.Reset();
tdl.Display();