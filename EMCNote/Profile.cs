﻿/*
 * Created by SharpDevelop.
 * User: jiangz3
 * Date: 6/25/2014
 * Time: 2:40 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace EMCNote
{
	/// <summary>
	/// Description of Profile.
	/// </summary>
	public class Profile
	{
		private String filename;
		private ProfileHelper helper;
		public Profile(String filename)
		{
			this.filename=filename;
			this.helper=new ProfileHelper(this);

			this.BookItems=new List<Book>();
		}
		public ProfileHelper Helper
		{
			get{
				return this.helper;
			}
		}
		public String ProfileName
		{
			get;set;
		}
		public String FileName
		{
			get{
				return this.filename;
			}
		}
		public List<Book> BookItems
		{
			//---TODO--- Readonly//
			get;set;
		}
		public List<Note> GetAllNotes()
		{
			return new List<Note>();
		}
		public List<Book> GetAllBooks()
		{
			return BookItems;
		}
		public Book newBook(String Name)
		{
			Book mybook=new Book(Name);
			BookItems.Add(mybook);
			return mybook;
		}
		public Book newBook(String Name, Book Parent)
		{
			Book mybook=new Book(Name,Parent);
			Parent.BookItems.Add(mybook);
			return mybook;
		}
		public Book FindBookByPath(String Path)
		{
			return null;
		}
		public Note FindNoteByPath(String Path)
		{
			return null;
		}
		public void Clear()
		{
			this.BookItems.Clear();
			GC.Collect();
		}
		
	}
}