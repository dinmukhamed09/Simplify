﻿using System;
using Simplify.FluentNHibernate.Examples.Domain.Location;
using Simplify.Repository;

namespace Simplify.FluentNHibernate.Examples.Domain.Accounts
{
	public class UsersService : IUsersService
	{
		private readonly IGenericRepository<IUser> _repository;

		public UsersService(IGenericRepository<IUser> repository)
		{
			_repository = repository;
		}

		public IUser GetUser(string userName)
		{
			if (userName == null) throw new ArgumentNullException(nameof(userName));

			return _repository.GetSingleByQuery(x => x.Name == userName);
		}

		public void SetUserCity(IUser user, ICity city)
		{
			if (user == null)
				throw new ArgumentNullException(nameof(user));

			user.City = city ?? throw new ArgumentNullException(nameof(city));

			_repository.Update(user);
		}
	}
}