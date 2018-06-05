using Cell.DAL.Models;
using Cell.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Cell.DAL.Helpers
{
    internal static class ModelExtensions
    {
        internal static Client ToDTO(this ClientDb clientDb)
        {
            return new Client
            {
                ClientId = clientDb.ClientId,
                FirstName = clientDb.FirstName,
                LastName = clientDb.LastName,
                Address = clientDb.Address,
                CallsToCenter = clientDb.CallsToCenter,
                ClientType = clientDb.ClientType.ToDTO(),
                Lines = clientDb.Lines.ToDTO().ToList(),
                Payments = clientDb.Payments.ToDTO().ToList(),
                ClientTypeId = clientDb.ClientTypeId
            };
        }

        internal static ClientDb FromDTO(this Client client)
        {
            return new ClientDb
            {
                ClientId = client.ClientId,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Address = client.Address,
                CallsToCenter = client.CallsToCenter,
                ClientType = client.ClientType.FromDTO(),
                Lines = client.Lines.FromDTO().ToList(),
                Payments = client.Payments.FromDTO().ToList(),
                ClientTypeId = client.ClientTypeId
            };
        }

        internal static IEnumerable<Client> ToDTO(this IEnumerable<ClientDb> clientDb)
        {
            foreach (var client in clientDb)
            {
                yield return client.ToDTO();
            }
        }

        internal static IEnumerable<ClientDb> FromDTO(this IEnumerable<Client> clients)
        {
            foreach (var client in clients)
            {
                yield return client.FromDTO();
            }
        }

        internal static Line ToDTO(this LineDb lineDb)
        {
            return new Line
            {
                Id = lineDb.Id,
                ClientId = lineDb.ClientId,
                Number = lineDb.Number,
                PackageId = lineDb.PackageId,
                Status = lineDb.Status,
                //Client = lineDb.Client.ToDTO(),
                //Packages = lineDb.Packages.ToDTO().ToList(),
                //SMSs = lineDb.SMSs.ToDTO().ToList(),
                //Calls = lineDb.Calls.ToDTO().ToList()
            };
        }

        internal static LineDb FromDTO(this Line line)
        {
            return new LineDb
            {
                Id = line.Id,
                ClientId = line.ClientId,
                Number = line.Number,
                PackageId = line.PackageId,
                Status = line.Status,
                //Client = line.Client.FromDTO(),
                //Packages = line.Packages.FromDTO().ToList(),
                //SMSs = line.SMSs.FromDTO().ToList(),
                //Calls = line.Calls.FromDTO().ToList()
            };
        }

        internal static IEnumerable<Line> ToDTO(this IEnumerable<LineDb> lines)
        {
            foreach (var line in lines)
            {
                yield return line.ToDTO();
            }
        }

        internal static IEnumerable<LineDb> FromDTO(this IEnumerable<Line> lines)
        {
            foreach (var line in lines)
            {
                yield return line.FromDTO();
            }
        }

        internal static ClientType ToDTO(this ClientTypeDb clientTypeDb)
        {
            return new ClientType
            {
                Id = clientTypeDb.Id,
                TypeName = clientTypeDb.TypeName,
                MinutePrice = clientTypeDb.MinutePrice,
                SmsPrice = clientTypeDb.SmsPrice,
               // Clients = clientTypeDb.Clients.ToDTO().ToList()
            };
        }

        internal static ClientTypeDb FromDTO(this ClientType clientType)
        {
            return new ClientTypeDb
            {
                Id = clientType.Id,
                TypeName = clientType.TypeName,
                MinutePrice = clientType.MinutePrice,
                SmsPrice = clientType.SmsPrice,
                //Clients = clientType.Clients.FromDTO().ToList()
            };
        }

        internal static IEnumerable<ClientType> ToDTO(this IEnumerable<ClientTypeDb> clientTypes)
        {
            foreach (var clientType in clientTypes)
            {
                yield return clientType.ToDTO();
            }
        }

        internal static IEnumerable<ClientTypeDb> FromDTO(this IEnumerable<ClientType> clientTypes)
        {
            foreach (var clientType in clientTypes)
            {
                yield return clientType.FromDTO();
            }
        }

        internal static Payment ToDTO(this PaymentDb paymentDb)
        {
            return new Payment
            {
                Id = paymentDb.Id,
                Month = paymentDb.Month,
                ClientId = paymentDb.ClientId,
                TotalPayment = paymentDb.TotalPayment,
                Client = paymentDb.Client.ToDTO(),
                Line = paymentDb.Line.ToDTO(),
                LineId = paymentDb.LineId
            };
        }

        internal static PaymentDb FromDTO(this Payment payment)
        {
            return new PaymentDb
            {
                Id = payment.Id,
                Month = payment.Month,
                ClientId = payment.ClientId,
                TotalPayment = payment.TotalPayment,
                Client = payment.Client.FromDTO(),
                Line = payment.Line.FromDTO(),
                LineId = payment.LineId
            };
        }

        internal static IEnumerable<Payment> ToDTO(this IEnumerable<PaymentDb> payments)
        {
            foreach (var payment in payments)
            {
                yield return payment.ToDTO();
            }
        }

        internal static IEnumerable<PaymentDb> FromDTO(this IEnumerable<Payment> payments)
        {
            foreach (var payment in payments)
            {
                yield return payment.FromDTO();
            }
        }

        internal static Call ToDTO(this CallDb callDb)
        {
            return new Call
            {
                Id = callDb.Id,
                DestinationNumber = callDb.DestinationNumber,
                Duration = callDb.Duration,
                ExternalPrice = callDb.ExternalPrice,
                LineId = callDb.LineId,
                Line = callDb.Line.ToDTO()
                };
        }

        internal static CallDb FromDTO(this Call calls)
        {
            return new CallDb
            {
                Id = calls.Id,
                DestinationNumber = calls.DestinationNumber,
                Duration = calls.Duration,
                ExternalPrice = calls.ExternalPrice,
                LineId = calls.LineId,
                Line = calls.Line.FromDTO()
            };
        }

        internal static IEnumerable<Call> ToDTO(this IEnumerable<CallDb> calls)
        {
            foreach (var call in calls)
            {
                yield return call.ToDTO();
            }
        }

        internal static IEnumerable<CallDb> FromDTO(this IEnumerable<Call> calls)
        {
            foreach (var call in calls)
            {
                yield return call.FromDTO();
            }
        }

        internal static SMS ToDTO(this SMSDb sMSDb)
        {
            return new SMS
            {
                Id = sMSDb.Id,
                DestinationNumber = sMSDb.DestinationNumber,
                ExternalPrice = sMSDb.ExternalPrice,
                Line = sMSDb.Line.ToDTO(),
                LineId = sMSDb.LineId
            };
        }

        internal static SMSDb FromDTO(this SMS sMS)
        {
            return new SMSDb
            {
                Id = sMS.Id,
                DestinationNumber = sMS.DestinationNumber,
                ExternalPrice = sMS.ExternalPrice,
                Line = sMS.Line.FromDTO(),
                LineId = sMS.LineId
            };
        }

        internal static IEnumerable<SMS> ToDTO(this IEnumerable<SMSDb> sMSs)
        {
            foreach (var sms in sMSs)
            {
                yield return sms.ToDTO();
            }
        }

        internal static IEnumerable<SMSDb> FromDTO(this IEnumerable<SMS> sMSs)
        {
            foreach (var sms in sMSs)
            {
                yield return sms.FromDTO();
            }
        }

        internal static Package ToDTO(this PackageDb packageDb)
        {
            return new Package
            {
                Id = packageDb.Id,
                //Line = packageDb.Line.ToDTO(),
                PackageTotalPrice = packageDb.PackageTotalPrice,
                PackageName = packageDb.PackageName,
                PackageIncludes = packageDb.PackageIncludes.ToDTO(),
                //LineId = packageDb.LineId,
                PackageIncludesId = packageDb.PackageIncludesId
            };
        }

        internal static PackageDb FromDTO(this Package package)
        {
            return new PackageDb
            {
                Id = package.Id,
                //Line = package.Line.FromDTO(),
                PackageTotalPrice = package.PackageTotalPrice,
                PackageName = package.PackageName,
                PackageIncludes = package.PackageIncludes.FromDTO(),
                //LineId = package.LineId,
                PackageIncludesId = package.PackageIncludesId
            };
        }

        internal static IEnumerable<Package> ToDTO(this IEnumerable<PackageDb> packages)
        {
            foreach (var package in packages)
            {
                yield return package.ToDTO();
            }
        }

        internal static IEnumerable<PackageDb> FromDTO(this IEnumerable<Package> packages)
        {
            foreach (var package in packages)
            {
                yield return package.FromDTO();
            }
        }

        internal static PackageIncludes ToDTO(this PackageIncludeDb packageIncludeDb)
        {
            return new PackageIncludes
            {
                Id = packageIncludeDb.Id,
                DiscountPrecentage = packageIncludeDb.DiscountPrecentage,
                FixedPrice = packageIncludeDb.FixedPrice,
                IncludeName = packageIncludeDb.IncludeName,
                InsideFamilyCalls = packageIncludeDb.InsideFamilyCalls,
                MaxMinute = packageIncludeDb.MaxMinute,
                MostCalledNumber = packageIncludeDb.MostCalledNumber,
                //PackageId = packageIncludeDb.PackageId,
                //Package = packageIncludeDb.Package.ToDTO(),
                //SelectedNumbersId = packageIncludeDb.SelectedNumbersId,
                //SelectedNumbers = packageIncludeDb.SelectedNumbers.ToDTO()
            };
        }

        internal static PackageIncludeDb FromDTO(this PackageIncludes packageIncludes)
        {
            return new PackageIncludeDb
            {
                Id = packageIncludes.Id,
                DiscountPrecentage = packageIncludes.DiscountPrecentage,
                FixedPrice = packageIncludes.FixedPrice,
                IncludeName = packageIncludes.IncludeName,
                InsideFamilyCalls = packageIncludes.InsideFamilyCalls,
                MaxMinute = packageIncludes.MaxMinute,
                MostCalledNumber = packageIncludes.MostCalledNumber,
                //PackageId = packageIncludes.PackageId,
                Package = packageIncludes.Package.FromDTO(),
                SelectedNumbersId = packageIncludes.SelectedNumbersId,
                SelectedNumbers = packageIncludes.SelectedNumbers.FromDTO()

            };
        }

        internal static IEnumerable<PackageIncludes> ToDTO(this IEnumerable<PackageIncludeDb> packageIncludes)
        {
            foreach (var packageInclude in packageIncludes)
            {
                yield return packageInclude.ToDTO();
            }
        }

        internal static IEnumerable<PackageIncludeDb> FromDTO(this IEnumerable<PackageIncludes> packageIncludes)
        {
            foreach (var packageInclude in packageIncludes)
            {
                yield return packageInclude.FromDTO();
            }
        }

        internal static SelectedNumbers ToDTO(this SelectedNumbersDb selectedNumbersDb)
        {
            return new SelectedNumbers
            {
                Id = selectedNumbersDb.Id,
                FirstNumber = selectedNumbersDb.FirstNumber,
                SecondNumber = selectedNumbersDb.SecondNumber,
                ThirdNumber = selectedNumbersDb.ThirdNumber,
                //PackageIncludesId = selectedNumbersDb.PackageIncludesId,
                //PackageIncludes = selectedNumbersDb.PackageIncludes.ToDTO()
            };
        }

        internal static SelectedNumbersDb FromDTO(this SelectedNumbers selectedNumbers)
        {
            return new SelectedNumbersDb
            {
                Id = selectedNumbers.Id,
                FirstNumber = selectedNumbers.FirstNumber,
                SecondNumber = selectedNumbers.SecondNumber,
                ThirdNumber = selectedNumbers.ThirdNumber,
                //PackageIncludesId = selectedNumbers.PackageIncludesId,
                //PackageIncludes = selectedNumbers.PackageIncludes.FromDTO()
            };
        }

        internal static IEnumerable<SelectedNumbers> ToDTO(this IEnumerable<SelectedNumbersDb> selectedNumbers)
        {
            foreach (var selectedNumber in selectedNumbers)
            {
                yield return selectedNumber.ToDTO();
            }
        }

        internal static IEnumerable<SelectedNumbersDb> FromDTO(this IEnumerable<SelectedNumbers> selectedNumbers)
        {
            foreach (var selectedNumber in selectedNumbers)
            {
                yield return selectedNumber.FromDTO();
            }
        }

        internal static User ToDTO(this UserDb userDb)
        {
            return new User
            {
                Id = userDb.Id,
                FullName = userDb.FullName,
                Password = userDb.Password
            };
        }

        internal static UserDb FromDTO(this User user)
        {
            return new UserDb
            {
                Id = user.Id,
                FullName = user.FullName,
                Password = user.Password
            };
        }
    }
}