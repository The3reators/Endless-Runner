using UnityEngine;
using System;

namespace TheCreators
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	public class ReadOnlyAttribute : PropertyAttribute { }
}