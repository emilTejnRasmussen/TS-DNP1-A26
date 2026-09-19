using Ex3___Doctors_waiting_room;

WaitingRoom waitingRoom = new();

Patient p1 = new(waitingRoom, 1);
Patient p2 = new(waitingRoom, 2);
Patient p3 = new(waitingRoom, 3);
Patient p4 = new(waitingRoom, 4);

waitingRoom.RunWaitingRoom();


