﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Valigator;
using Valigator.Tests.Common;
using Xunit;

namespace Valigator.Tests
{
	public class StateValidatorTests
	{
		[Fact]
		public void RequiredWithValue()
			=> Data
				.Required<int>()
				.Nullable()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredWithNull()
			=> Data
				.Required<int>()
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertFailure();

		[Fact]
		public void RequiredAndUnset()
			=> Data
				.Required<int>()
				.Nullable()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertFailure();

		[Fact]
		public void RequiredNullableWithValue()
			=> Data
				.Required<int>()
				.Nullable()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void RequiredNullableWithNull()
			=> Data
				.Required<int>()
				.Nullable()
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void RequiredNullableAndUnset()
			=> Data
				.Required<int>()
				.Nullable()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertFailure();

		[Fact]
		public void OptionalWithValue()
			=> Data
				.Optional<int>()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void OptionalWithNull()
			=> Data
				.Optional<int>()
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertFailure();

		[Fact]
		public void OptionalAndUnset()
			=> Data
				.Optional<int>()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();


		[Fact]
		public void OptionalNullableWithValue()
			=> Data
				.Optional<int>()
				.Nullable()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void OptionalNullableWithNull()
			=> Data
				.Optional<int>()
				.Nullable()
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void OptionalNullableAndUnset()
			=> Data
				.Optional<int>()
				.Nullable()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void DefaultedWithValue()
			=> Data
				.Defaulted(10)
				.Nullable()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void DefaultedWithNull()
			=> Data
				.Defaulted(10)
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertFailure();

		[Fact]
		public void DefaultedAndUnset()
			=> Data
				.Defaulted(10)
				.Nullable()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(10);

		[Fact]
		public void DefaultedNullableWithValue()
			=> Data
				.Defaulted(10)
				.Nullable()
				.Data
				.WithValue(5)
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(5);

		[Fact]
		public void DefaultedNullableWithNull()
			=> Data
				.Defaulted(10)
				.Nullable()
				.Data
				.WithNull()
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertNone();

		[Fact]
		public void DefaultedNullableAndUnset()
			=> Data
				.Defaulted(10)
				.Nullable()
				.Data
				.Verify(new object())
				.TryGetValue()
				.AssertSuccess()
				.AssertSome()
				.Should()
				.Be(10);
	}
}
