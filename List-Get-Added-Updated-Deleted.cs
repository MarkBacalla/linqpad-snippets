void Main()
{
	var listofIds = new List<UserQuery.ClassA>();
	
	var newListofIds = new List<int>(); // usually a parameter
	IEnumerable<int> existingIds = listofIds.Select(psa => psa.ID);
	IEnumerable<int> idsToBeDeleted = existingIds.Except(newListofIds);
	IEnumerable<int> toBeAdded = newListofIds.Except(existingIds);
	
	// process the list
}

// Define other methods and classes here
public class ClassA {
	public int ID { get; set; }
}
