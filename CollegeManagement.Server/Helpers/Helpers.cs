using System.Data;

namespace CollegeManagement.Server.Helpers
{
	public static class Helpers
	{
		public static DataTable ToDataTable(List<object> items)
		{
			if (items == null || items.Count == 0)
				throw new ArgumentException("The list is null or empty.");

			DataTable dataTable = new DataTable();

			// Get properties of the first object in the list
			var properties = items[0].GetType().GetProperties();

			// Create columns in the DataTable based on properties of the objects
			foreach (var property in properties)
			{
				dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
			}

			// Add rows to the DataTable
			foreach (var item in items)
			{
				var values = new object[properties.Length];
				for (int i = 0; i < properties.Length; i++)
				{
					values[i] = properties[i].GetValue(item);
				}
				dataTable.Rows.Add(values);
			}

			return dataTable;
		}

	}
}
