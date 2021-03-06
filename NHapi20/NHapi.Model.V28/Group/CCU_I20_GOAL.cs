using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the CCU_I20_GOAL Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: GOL (Goal Detail) </li>
///<li>1: VAR (Variance) optional repeating</li>
///<li>2: CCU_I20_ROLE_GOAL (a Group object) optional repeating</li>
///<li>3: CCU_I20_GOAL_OBSERVATION (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class CCU_I20_GOAL : AbstractGroup {

	///<summary> 
	/// Creates a new CCU_I20_GOAL Group.
	///</summary>
	public CCU_I20_GOAL(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(GOL), true, false);
	      this.add(typeof(VAR), false, true);
	      this.add(typeof(CCU_I20_ROLE_GOAL), false, true);
	      this.add(typeof(CCU_I20_GOAL_OBSERVATION), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating CCU_I20_GOAL - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns GOL (Goal Detail) - creates it if necessary
	///</summary>
	public GOL GOL { 
get{
	   GOL ret = null;
	   try {
	      ret = (GOL)this.GetStructure("GOL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of VAR (Variance) - creates it if necessary
	///</summary>
	public VAR GetVAR() {
	   VAR ret = null;
	   try {
	      ret = (VAR)this.GetStructure("VAR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of VAR
	/// * (Variance) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public VAR GetVAR(int rep) { 
	   return (VAR)this.GetStructure("VAR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of VAR 
	 */ 
	public int VARRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("VAR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the VAR results 
	 */ 
	public IEnumerable<VAR> VARs 
	{ 
		get
		{
			for (int rep = 0; rep < VARRepetitionsUsed; rep++)
			{
				yield return (VAR)this.GetStructure("VAR", rep);
			}
		}
	}

	///<summary>
	///Adds a new VAR
	///</summary>
	public VAR AddVAR()
	{
		return this.AddStructure("VAR") as VAR;
	}

	///<summary>
	///Removes the given VAR
	///</summary>
	public void RemoveVAR(VAR toRemove)
	{
		this.RemoveStructure("VAR", toRemove);
	}

	///<summary>
	///Removes the VAR at the given index
	///</summary>
	public void RemoveVARAt(int index)
	{
		this.RemoveRepetition("VAR", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_ROLE_GOAL (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_ROLE_GOAL GetROLE_GOAL() {
	   CCU_I20_ROLE_GOAL ret = null;
	   try {
	      ret = (CCU_I20_ROLE_GOAL)this.GetStructure("ROLE_GOAL");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_ROLE_GOAL
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_ROLE_GOAL GetROLE_GOAL(int rep) { 
	   return (CCU_I20_ROLE_GOAL)this.GetStructure("ROLE_GOAL", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_ROLE_GOAL 
	 */ 
	public int ROLE_GOALRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ROLE_GOAL").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_ROLE_GOAL results 
	 */ 
	public IEnumerable<CCU_I20_ROLE_GOAL> ROLE_GOALs 
	{ 
		get
		{
			for (int rep = 0; rep < ROLE_GOALRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_ROLE_GOAL)this.GetStructure("ROLE_GOAL", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_ROLE_GOAL
	///</summary>
	public CCU_I20_ROLE_GOAL AddROLE_GOAL()
	{
		return this.AddStructure("ROLE_GOAL") as CCU_I20_ROLE_GOAL;
	}

	///<summary>
	///Removes the given CCU_I20_ROLE_GOAL
	///</summary>
	public void RemoveROLE_GOAL(CCU_I20_ROLE_GOAL toRemove)
	{
		this.RemoveStructure("ROLE_GOAL", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_ROLE_GOAL at the given index
	///</summary>
	public void RemoveROLE_GOALAt(int index)
	{
		this.RemoveRepetition("ROLE_GOAL", index);
	}

	///<summary>
	/// Returns  first repetition of CCU_I20_GOAL_OBSERVATION (a Group object) - creates it if necessary
	///</summary>
	public CCU_I20_GOAL_OBSERVATION GetGOAL_OBSERVATION() {
	   CCU_I20_GOAL_OBSERVATION ret = null;
	   try {
	      ret = (CCU_I20_GOAL_OBSERVATION)this.GetStructure("GOAL_OBSERVATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of CCU_I20_GOAL_OBSERVATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public CCU_I20_GOAL_OBSERVATION GetGOAL_OBSERVATION(int rep) { 
	   return (CCU_I20_GOAL_OBSERVATION)this.GetStructure("GOAL_OBSERVATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of CCU_I20_GOAL_OBSERVATION 
	 */ 
	public int GOAL_OBSERVATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("GOAL_OBSERVATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the CCU_I20_GOAL_OBSERVATION results 
	 */ 
	public IEnumerable<CCU_I20_GOAL_OBSERVATION> GOAL_OBSERVATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < GOAL_OBSERVATIONRepetitionsUsed; rep++)
			{
				yield return (CCU_I20_GOAL_OBSERVATION)this.GetStructure("GOAL_OBSERVATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new CCU_I20_GOAL_OBSERVATION
	///</summary>
	public CCU_I20_GOAL_OBSERVATION AddGOAL_OBSERVATION()
	{
		return this.AddStructure("GOAL_OBSERVATION") as CCU_I20_GOAL_OBSERVATION;
	}

	///<summary>
	///Removes the given CCU_I20_GOAL_OBSERVATION
	///</summary>
	public void RemoveGOAL_OBSERVATION(CCU_I20_GOAL_OBSERVATION toRemove)
	{
		this.RemoveStructure("GOAL_OBSERVATION", toRemove);
	}

	///<summary>
	///Removes the CCU_I20_GOAL_OBSERVATION at the given index
	///</summary>
	public void RemoveGOAL_OBSERVATIONAt(int index)
	{
		this.RemoveRepetition("GOAL_OBSERVATION", index);
	}

}
}
