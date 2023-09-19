﻿using CarWorkshop.Application.CarWorkshop.Commands.CreateCarWorkshop;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CarWorkshop.Application.CarWorkshopService.Commands.Tests
{
    public class CreateCarWorkshopServiceCommandValidatorTests
    {
        [Fact()]
        public void Validate_IfValidCommand_ShouldNotHaveError()
        {
             // arrange

            var validator = new CreateCarWorkshopServiceCommandValidator();
            var command = new CreateCarWorkshopServiceCommand()
            {
                Cost = "100 PLN",
                Description = "Description",
                CarWorkshopEncodedName = "workshop1"
            };

            // act

            var result = validator.TestValidate(command);

            // assert

            result.ShouldNotHaveAnyValidationErrors();
        }
        [Fact()]
        public void Validate_IfInValidCommand_ShouldHaveError()
        {
            // arrange

            var validator = new CreateCarWorkshopServiceCommandValidator();
            var command = new CreateCarWorkshopServiceCommand()
            {
                Cost = "",
                Description = "",
                CarWorkshopEncodedName = null
            };

            // act

            var result = validator.TestValidate(command);

            // assert

            result.ShouldHaveValidationErrorFor(c => c.Cost);
            result.ShouldHaveValidationErrorFor(c => c.Description);
            result.ShouldHaveValidationErrorFor(c => c.CarWorkshopEncodedName);
        }
    }
}
