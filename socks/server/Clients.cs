using System;
using System.Collections.Generic;


public class Clients{
	private SortedDictionary<int,Client> clients;
	public Clients(){
		
		clients = new SortedDictionary<int,Client>();
	}
	public int add(){
       		Client cl = new Client(0);
		int retval = clients.Count;
		while(clients.ContainsKey(retval)){
			retval++;
		}
		clients.Add(retval,cl);
		return retval;
	}
	public Client get (int id){
		if (!clients.ContainsKey(id)){
			return null;
		}
		return clients.Item[id];
	}
	public void remove (int id){
		if (!clients.ContainsKey(id)){
			return;
		}
		clients.Remove(id);
	}
}

