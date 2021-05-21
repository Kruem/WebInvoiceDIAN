using Asiscomex.Webinvoice.Helpers;
using Asiscomex.Webinvoice.Models.Xml;
using Asiscomex.Webinvoice.Qr;
using Asiscomex.Webinvoice.Services;
using System;
using Xunit;

namespace Asiscomex.WebInvoice.Test
{
    public class UnitTest1
    {
        private readonly Invoice invoice = new Invoice()
        {
            UBLExtensions = new UblExtensions()
            {
                UBLExtension = new UblExtension()
                {
                    ExtensionContent = new ExtensionContent()
                    {
                        DianExtensions = new DianExtensions()
                        {
                            InvoiceControl = new InvoiceControl()
                            {
                                AuthorizationPeriod = new AuthorizationPeriod()
                                {
                                    StartDate = new DateTime(2019, 1, 19),
                                    EndDate = new DateTime(2030, 1, 19),
                                },
                                InvoiceAuthorization = "18760000001",
                                AuthorizedInvoices = new AuthorizedInvoices()
                                {
                                    From = "1",
                                    Prefix = "SETT",
                                    To = "5000000"
                                }
                            }
                        }
                    }
                }
            },
            CustomizationID = "05",
            ProfileExecutionId = 2,
            Id = new Id() { Text = "SETT03" },
            IssueDate = new DateTime(2020, 7, 17, 19, 24, 36),
            InvoiceTypeCode = "01",
            Note = "Prueba Factura Electronica Datos Reales",
            DocumentCurrencyCode = "COP",
            LineCountNumeric = 1,
            AccountingSupplierParty = new AccountingSupplierParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name() { Text = "NOVAFREIGHT S.A.S" }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id() { Text = "05631" },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "5",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id() { Text = "05631" },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id() { Text = "01" },
                            Name = new Name() { Text = "IVA" }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "5",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Id = new Id() { Text = "SETT" },
                            Name = new Name() { Text = "218282" }
                        }
                    },
                    Contact = new Contact() { ElectronicMail = "auxcont@novafreight.com.co" }
                }
            },
            AccountingCustomerParty = new AccountingCustomerParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name() { Text = "NOVAFREIGHT S.A.S" }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id() { Text = "05631" },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "Antioquia",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id() { Text = "05001" },
                            CityName = "Medellin",
                            PostalZone = "05001",
                            CountrySubentity = "Antioquia",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 72 # 45 - 28"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id() { Text = "01" },
                            Name = new Name() { Text = "IVA" }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Name = new Name() { Text = "64856412" }
                        }
                    },
                    Contact = new Contact() { ElectronicMail = "gerencia@asiscomex.co" }
                },
            },
            PaymentMeans = new PaymentMeans()
            {
                Id = new Id() { Text = "1" },
                PaymentMeansCode = "10",
                PaymentId = "Efectivo"
            },
            TaxTotal = new TaxTotal()
            {
                TaxAmount = new TaxAmount()
                {
                    CurrencyId = "COP",
                    Text = "19000.00"
                },
                TaxSubtotal = new TaxSubtotal()
                {
                    TaxableAmount = new TaxableAmount()
                    {
                        CurrencyId = "COP",
                        Text = "100000.00"
                    },
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxCategory = new TaxCategory()
                    {
                        Percent = "19.00",
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id() { Text = "01" },
                            Name = new Name() { Text = "IVA" }
                        }
                    }
                }
            },
            LegalMonetaryTotal = new LegalMonetaryTotal()
            {
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxExclusiveAmount = new TaxExclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxInclusiveAmount = new TaxInclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                },
                PayableAmount = new PayableAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                }
            },
            InvoiceLine = new InvoiceLine()
            {

                Id = new Id() { Text = "1" },
                InvoicedQuantity = "1.00",
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxTotal = new TaxTotal()
                {
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxSubtotal = new TaxSubtotal()
                    {
                        TaxableAmount = new TaxableAmount()
                        {
                            CurrencyId = "COP",
                            Text = "100000.00"
                        },
                        TaxAmount = new TaxAmount()
                        {
                            CurrencyId = "COP",
                            Text = "19000.00"
                        },
                        TaxCategory = new TaxCategory()
                        {
                            Percent = "19.00",
                            TaxScheme = new TaxScheme()
                            {
                                Id = new Id() { Text = "01" },
                                Name = new Name() { Text = "IVA" }
                            }
                        }
                    }
                },
                Item = new Item()
                {
                    Description = "Paquete de software de transacciones comerciales y personales",
                    StandardItemIdentification = new StandardItemIdentification()
                    {
                        Id = new Id()
                        {
                            SchemeId = "999",
                            Text = "48430000"
                        }
                    }
                },
                Price = new Price()
                {
                    PriceAmount = new PriceAmount()
                    {
                        CurrencyID = "COP",
                        Text = "100000.00"
                    },
                    BaseQuantity = new BaseQuantity()
                    {
                        UnitCode = "EA",
                        Text = "1.00"
                    }
                }
            },
            Data = new Data()
            {
                UBL21 = "true",
                Partnership = new Partnership()
                {
                    Id = new Id() { Text = "Your NIT" },
                    TechKey = "fc8eac422eba16e22ffd8c6f94b3f40a6e38162c",
                    SetTestID = "3cf1be28-e65d-448c-8a74-990edd09e358"
                }
            }
        };

        private readonly CreditNote creditNote = new CreditNote()
        {
            CustomizationId = "05",
            ProfileExecutionId = "2",
            Id = new Id() { Text = "NC-01" },
            IssueDate = new DateTime(2020, 7, 17, 21, 09, 36),
            CreditNoteTypeCode = "91",
            Note = "Nota Credito Prueba 1",
            DocumentCurrencyCode = "COP",
            LineCountNumeric = "1",
            DiscrepancyResponse = new DiscrepancyResponse()
            {
                ReferenceId = "SETT03",
                ResponseCode = "2",
                Description = "Anulación de factura electrónica"
            },
            BillingReference = new BillingReference()
            {
                InvoiceDocumentReference = new InvoiceDocumentReference()
                {
                    Id = new Id() { Text = "SETT03" },
                    IssueDate = new DateTime(2020, 07, 17)
                }
            },
            AccountingSupplierParty = new AccountingSupplierParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name()
                        {
                            Text = "NOVAFREIGHT S.A.S"
                        }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "1",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "900606682"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id()
                            {
                                Text = "01"
                            },
                            Name = new Name()
                            {
                                Text = "IVA"
                            }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "1",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "900606682"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Id = new Id()
                            {
                                Text = "NC",
                            },
                            Name = new Name()
                            {
                                Text = "218282"
                            }
                        },
                    },
                    Contact = new Contact()
                    {
                        ElectronicMail = "auxcont@novafreight.com.co07"
                    }
                }
            },
            AccountingCustomerParty = new AccountingCustomerParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name()
                        {
                            Text = "HOSTAL GROUP S.A.S"
                        }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "MEDELLIN",
                            PostalZone = "05001",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 72 # 45 - 28"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "MEDELLIN",
                            PostalZone = "05001",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 72 # 45 - 28"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id()
                            {
                                Text = "01"
                            },
                            Name = new Name()
                            {
                                Text = "IVA"
                            }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Name = new Name()
                            {
                                Text = "64856412"
                            }
                        },
                    },
                    Contact = new Contact()
                    {
                        ElectronicMail = "gerencia@asiscomex.co"
                    }
                }
            },
            PaymentMeans = new PaymentMeans()
            {
                Id = new Id()
                {
                    Text = "1"
                },
                PaymentMeansCode = "10",
                PaymentId = "Efectivo"
            },
            TaxTotal = new TaxTotal()
            {
                TaxAmount = new TaxAmount()
                {
                    CurrencyId = "COP",
                    Text = "19000.00"
                },
                TaxSubtotal = new TaxSubtotal()
                {
                    TaxableAmount = new TaxableAmount()
                    {
                        CurrencyId = "COP",
                        Text = "100000.00"
                    },
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxCategory = new TaxCategory()
                    {
                        Percent = "19.00",
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id() { Text = "01" },
                            Name = new Name() { Text = "IVA" }
                        }
                    }
                }
            },
            LegalMonetaryTotal = new LegalMonetaryTotal()
            {
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxExclusiveAmount = new TaxExclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxInclusiveAmount = new TaxInclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                },
                PayableAmount = new PayableAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                }
            },
            CreditNoteLine = new CreditNoteLine()
            {
                Id = new Id() { Text = "1" },
                CreditedQuantity = new CreditedQuantity()
                {
                    UnitCode = "EA",
                    Text = "1.00"
                },
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxTotal = new TaxTotal()
                {
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxSubtotal = new TaxSubtotal()
                    {
                        TaxableAmount = new TaxableAmount()
                        {
                            CurrencyId = "COP",
                            Text = "100000.00"
                        },
                        TaxAmount = new TaxAmount()
                        {
                            CurrencyId = "COP",
                            Text = "19000.00"
                        },
                        TaxCategory = new TaxCategory()
                        {
                            Percent = "19.00",
                            TaxScheme = new TaxScheme()
                            {
                                Id = new Id() { Text = "01" },
                                Name = new Name() { Text = "IVA" }
                            }
                        }
                    }
                },
                Item = new Item()
                {
                    Description = "Paquete de software de transacciones comerciales y personales",
                    StandardItemIdentification = new StandardItemIdentification()
                    {
                        Id = new Id()
                        {
                            SchemeId = "999",
                            Text = "48430000"
                        }
                    }
                },
                Price = new Price()
                {
                    PriceAmount = new PriceAmount()
                    {
                        CurrencyID = "COP",
                        Text = "100000.00"
                    },
                    BaseQuantity = new BaseQuantity()
                    {
                        UnitCode = "EA",
                        Text = "1.00"
                    }
                }
            },
            Data = new Data()
            {
                UBL21 = "true",
                Partnership = new Partnership()
                {
                    Id = new Id() { Text = "Your NIT" },
                    TechKey = "fc8eac422eba16e22ffd8c6f94b3f40a6e38162c",
                    SetTestID = "90f7fb9f-d379-45fa-8894-4f999a398efa"
                }
            }
        };

        private readonly DebitNote debitNote = new DebitNote()
        {
            CustomizationId = "05",
            ProfileExecutionId = "2",
            Id = new Id() { Text = "ND-01" },
            IssueDate = new DateTime(2020, 7, 17, 21, 09, 36),
            CreditNoteTypeCode = "91",
            Note = "Nota Debito Prueba 1",
            DocumentCurrencyCode = "COP",
            LineCountNumeric = "1",
            DiscrepancyResponse = new DiscrepancyResponse()
            {
                ReferenceId = "SETT03",
                ResponseCode = "2",
                Description = "Anulación de factura electrónica"
            },
            BillingReference = new BillingReference()
            {
                InvoiceDocumentReference = new InvoiceDocumentReference()
                {
                    Id = new Id() { Text = "SETT03" },
                    IssueDate = new DateTime(2020, 07, 17)
                }
            },
            AccountingSupplierParty = new AccountingSupplierParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name()
                        {
                            Text = "NOVAFREIGHT S.A.S"
                        }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "1",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "900606682"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "SABANETA",
                            PostalZone = "05631",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 60B SUR # 44 - 100 OF 908"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id()
                            {
                                Text = "01"
                            },
                            Name = new Name()
                            {
                                Text = "IVA"
                            }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "NOVAFREIGHT S.A.S",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "1",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "900606682"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Id = new Id()
                            {
                                Text = "NC",
                            },
                            Name = new Name()
                            {
                                Text = "218282"
                            }
                        },
                    },
                    Contact = new Contact()
                    {
                        ElectronicMail = "auxcont@novafreight.com.co07"
                    }
                }
            },
            AccountingCustomerParty = new AccountingCustomerParty()
            {
                AdditionalAccountId = 1,
                Party = new Party()
                {
                    PartyName = new PartyName()
                    {
                        Name = new Name()
                        {
                            Text = "HOSTAL GROUP S.A.S"
                        }
                    },
                    PhysicalLocation = new PhysicalLocation()
                    {
                        Address = new Address()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "MEDELLIN",
                            PostalZone = "05001",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 72 # 45 - 28"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        }
                    },
                    PartyTaxScheme = new PartyTaxScheme()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        TaxLevelCode = new TaxLevelCode()
                        {
                            ListName = "48",
                            Text = "O-48"
                        },
                        RegistrationAddress = new RegistrationAddress()
                        {
                            Id = new Id()
                            {
                                Text = "05001"
                            },
                            CityName = "MEDELLIN",
                            PostalZone = "05001",
                            CountrySubentity = "ANTIOQUIA",
                            CountrySubentityCode = "05",
                            AddressLine = new AddressLine()
                            {
                                Line = "CALLE 72 # 45 - 28"
                            },
                            Country = new Country()
                            {
                                IdentificationCode = "CO",
                                Name = new Name()
                                {
                                    LanguageId = "es",
                                    Text = "Colombia"
                                }
                            }
                        },
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id()
                            {
                                Text = "01"
                            },
                            Name = new Name()
                            {
                                Text = "IVA"
                            }
                        }
                    },
                    PartyLegalEntity = new PartyLegalEntity()
                    {
                        RegistrationName = "HOSTAL GROUP S.A.S.",
                        CompanyId = new CompanyId()
                        {
                            SchemeId = "2",
                            SchemeName = "31",
                            SchemeAgencyId = "195",
                            SchemeAgencyName = "CO, DIAN (Dirección de Impuestos y Aduanas Nacionales)",
                            Text = "901288699"
                        },
                        CorporateRegistrationScheme = new CorporateRegistrationScheme()
                        {
                            Name = new Name()
                            {
                                Text = "64856412"
                            }
                        },
                    },
                    Contact = new Contact()
                    {
                        ElectronicMail = "gerencia@asiscomex.co"
                    }
                }
            },
            PaymentMeans = new PaymentMeans()
            {
                Id = new Id()
                {
                    Text = "1"
                },
                PaymentMeansCode = "10",
                PaymentId = "Efectivo"
            },
            TaxTotal = new TaxTotal()
            {
                TaxAmount = new TaxAmount()
                {
                    CurrencyId = "COP",
                    Text = "19000.00"
                },
                TaxSubtotal = new TaxSubtotal()
                {
                    TaxableAmount = new TaxableAmount()
                    {
                        CurrencyId = "COP",
                        Text = "100000.00"
                    },
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxCategory = new TaxCategory()
                    {
                        Percent = "19.00",
                        TaxScheme = new TaxScheme()
                        {
                            Id = new Id() { Text = "01" },
                            Name = new Name() { Text = "IVA" }
                        }
                    }
                }
            },
            RequestedMonetaryTotal = new RequestedMonetaryTotal()
            {
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxExclusiveAmount = new TaxExclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxInclusiveAmount = new TaxInclusiveAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                },
                PayableAmount = new PayableAmount()
                {
                    CurrencyId = "COP",
                    Text = "119000.00"
                }
            },
            DebitNoteLine = new DebitNoteLine()
            {
                Id = new Id() { Text = "1" },
                DebitedQuantity = new DebitedQuantity()
                {
                    UnitCode = "EA",
                    Text = "1.00"
                },
                LineExtensionAmount = new LineExtensionAmount()
                {
                    CurrencyId = "COP",
                    Text = "100000.00"
                },
                TaxTotal = new TaxTotal()
                {
                    TaxAmount = new TaxAmount()
                    {
                        CurrencyId = "COP",
                        Text = "19000.00"
                    },
                    TaxSubtotal = new TaxSubtotal()
                    {
                        TaxableAmount = new TaxableAmount()
                        {
                            CurrencyId = "COP",
                            Text = "100000.00"
                        },
                        TaxAmount = new TaxAmount()
                        {
                            CurrencyId = "COP",
                            Text = "19000.00"
                        },
                        TaxCategory = new TaxCategory()
                        {
                            Percent = "19.00",
                            TaxScheme = new TaxScheme()
                            {
                                Id = new Id() { Text = "01" },
                                Name = new Name() { Text = "IVA" }
                            }
                        }
                    }
                },

                Item = new Item()
                {
                    Description = "Paquete de software de transacciones comerciales y personales",
                    StandardItemIdentification = new StandardItemIdentification()
                    {
                        Id = new Id()
                        {
                            SchemeId = "999",
                            Text = "48430000"
                        }
                    }
                },
                Price = new Price()
                {
                    PriceAmount = new PriceAmount()
                    {
                        CurrencyID = "COP",
                        Text = "100000.00"
                    },
                    BaseQuantity = new BaseQuantity()
                    {
                        UnitCode = "EA",
                        Text = "1.00"
                    }
                }
            },
            Data = new Data()
            {
                UBL21 = "true",
                Partnership = new Partnership()
                {
                    Id = new Id() { Text = "Your Nit" },
                    TechKey = "fc8eac422eba16e22ffd8c6f94b3f40a6e38162c",
                    SetTestID = "90f7fb9f-d379-45fa-8894-4f999a398efa"
                }
            }
        };

        [Fact]
        public void InvoiceService_ExecuteInvoice_Successful()
        {
            invoice.Uuid = new Uuid() { SchemeID = "2", SchemeName = "CUFE-SHA384", Text = Sha384Helper.BuildSha384(invoice.Id.Text, invoice.IssueDateString, invoice.IssueTimeString, invoice.LegalMonetaryTotal.LineExtensionAmount.Text, invoice.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, invoice.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", invoice.LegalMonetaryTotal.PayableAmount.Text, invoice.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, invoice.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, invoice.Data.Partnership.TechKey, invoice.ProfileExecutionId.ToString()) };
            var invoiceService = new InvoiceService("https://apivp.efacturacadena.com/staging/vp-hab/documentos/proceso/alianzas", "12345");
            var responce = invoiceService.Execute(invoice);
            Assert.True(responce.Successful);
        }

        [Fact]
        public void InvoiceService_ExecuteCreditNote_Successful()
        {
            creditNote.Uuid = new Uuid() { SchemeID = "2", SchemeName = "CUDE-SHA384", Text = Sha384Helper.BuildSha384(creditNote.Id.Text, creditNote.IssueDateString, creditNote.IssueTimeString, creditNote.LegalMonetaryTotal.LineExtensionAmount.Text, creditNote.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, creditNote.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", creditNote.LegalMonetaryTotal.PayableAmount.Text, creditNote.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, creditNote.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, "75315", creditNote.ProfileExecutionId.ToString()) };
            creditNote.BillingReference.InvoiceDocumentReference.Uuid = new Uuid() { SchemeName = "CUFE-SHA384", Text = Sha384Helper.BuildSha384(creditNote.Id.Text, creditNote.IssueDateString, creditNote.IssueTimeString, creditNote.LegalMonetaryTotal.LineExtensionAmount.Text, creditNote.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, creditNote.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", creditNote.LegalMonetaryTotal.PayableAmount.Text, creditNote.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, creditNote.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, creditNote.Data.Partnership.TechKey, creditNote.ProfileExecutionId.ToString()) };
            var creditNoteService = new InvoiceService("https://apivp.efacturacadena.com/staging/vp-hab/documentos/proceso/alianzas", "12345");
            var responce = creditNoteService.Execute(creditNote);
            Assert.True(responce.Successful);
        }

        [Fact]
        public void InvoiceService_ExecuteDebitNote_Successful()
        {
            debitNote.Uuid = new Uuid() { SchemeID = "2", SchemeName = "CUDE-SHA384", Text = Sha384Helper.BuildSha384(debitNote.Id.Text, debitNote.IssueDateString, debitNote.IssueTimeString, debitNote.RequestedMonetaryTotal.LineExtensionAmount.Text, debitNote.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, debitNote.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", debitNote.RequestedMonetaryTotal.PayableAmount.Text, debitNote.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, debitNote.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, "75315", debitNote.ProfileExecutionId.ToString()) };
            debitNote.BillingReference.InvoiceDocumentReference.Uuid = new Uuid() { SchemeName = "CUFE-SHA384", Text = Sha384Helper.BuildSha384(debitNote.Id.Text, debitNote.IssueDateString, debitNote.IssueTimeString, debitNote.RequestedMonetaryTotal.LineExtensionAmount.Text, debitNote.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, debitNote.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", debitNote.RequestedMonetaryTotal.PayableAmount.Text, debitNote.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, debitNote.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, debitNote.Data.Partnership.TechKey, debitNote.ProfileExecutionId.ToString()) };
            var debitNoteService = new InvoiceService("https://apivp.efacturacadena.com/staging/vp-hab/documentos/proceso/alianzas", "12345");
            var responce = debitNoteService.Execute(debitNote);
            Assert.True(responce.Successful);
        }

        [Fact]
        public void InvoiceQr_CreateAndSave_Successful()
        {
            invoice.Uuid = new Uuid() { SchemeID = "2", SchemeName = "CUFE-SHA384", Text = Sha384Helper.BuildSha384(invoice.Id.Text, invoice.IssueDateString, invoice.IssueTimeString, invoice.LegalMonetaryTotal.LineExtensionAmount.Text, invoice.TaxTotal.TaxSubtotal.TaxCategory.TaxScheme.Id.Text, invoice.TaxTotal.TaxAmount.Text, "04", "0.00", "03", "0.00", invoice.LegalMonetaryTotal.PayableAmount.Text, invoice.AccountingSupplierParty.Party.PartyTaxScheme.CompanyId.Text, invoice.AccountingCustomerParty.Party.PartyTaxScheme.CompanyId.Text, invoice.Data.Partnership.TechKey, invoice.ProfileExecutionId.ToString()) };
            InvoiceQr.CreateAndSave(invoice, @"C:\Users\Stuart\Desktop\testQR\qr.bmp");
        }
    }
}
