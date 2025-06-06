﻿using CommonConversions.Application.Services;
using CommonConversions.Core.Interfaces;
using Moq;

namespace CommonConversions.Application.UnitTests.Services;

public class ConversionServiceTests
{

    private readonly Mock<IConvertHistoryRepository> _repositoryMock;
    private readonly ConversionService _service;
    
    public ConversionServiceTests()
    {
        _repositoryMock = new Mock<IConvertHistoryRepository>();
        _service = new ConversionService(_repositoryMock.Object);
    }

    [Fact]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        // Arrange
        double input = 0;

        // Act
        double result = _service.CelsiusToFahrenheit(input);

        // Assert
        Assert.Equal(32, result);
    }

    [Fact]
    public void KilometersToMiles_ShouldConvertCorrectly()
    {
        // Arrange

        // Act
        double result = _service.KilometersToMiles(1);

        // Assert
        Assert.Equal(0.621371, result, 5);
    }

    [Fact]
    public void KilogramsToPounds_ShouldConvertCorrectly()
    {
        // Arrange

        // Act
        double result = _service.KilogramsToPounds(1);

        // Assert
        Assert.Equal(2.20462, result, 5);
    }
}