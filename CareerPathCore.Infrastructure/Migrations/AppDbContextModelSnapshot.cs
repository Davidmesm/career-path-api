﻿// <auto-generated />
using System;
using CareerPathCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CareerPathCore.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CareerPathCore.Domain.Entities.EducationLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("EducationLevels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c352b73c-7e12-43a8-9fb1-8e3a663e4795"),
                            Name = "No Formal Education"
                        },
                        new
                        {
                            Id = new Guid("90b06b5f-9c96-4616-a8cb-1225f56a668d"),
                            Name = "High School Diploma or Equivalent"
                        },
                        new
                        {
                            Id = new Guid("f5c7c475-b7ad-44a1-ad5a-d1803f34cc0b"),
                            Name = "Associate's Degree"
                        },
                        new
                        {
                            Id = new Guid("ca96a6fe-5ca4-48e1-b5a0-345b4794c7ee"),
                            Name = "Bachelor's Degree"
                        },
                        new
                        {
                            Id = new Guid("bca3c81f-3a55-4a20-89e4-7ad434e54540"),
                            Name = "Master's Degree"
                        },
                        new
                        {
                            Id = new Guid("87aafb4c-42e7-4bdc-aada-7d042b1c9678"),
                            Name = "Doctorate (Ph.D.)"
                        },
                        new
                        {
                            Id = new Guid("93d218a3-b378-4037-b2bc-cd4370ee630c"),
                            Name = "Professional Certification"
                        });
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.JobArea", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JobAreas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            Name = "Frontend Engineering"
                        },
                        new
                        {
                            Id = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            Name = "Backend Engineering"
                        },
                        new
                        {
                            Id = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            Name = "Fullstack Engineering"
                        },
                        new
                        {
                            Id = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            Name = "Manual Testing"
                        },
                        new
                        {
                            Id = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            Name = "Automation Testing"
                        },
                        new
                        {
                            Id = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            Name = "DevOps/SRE/Infra"
                        },
                        new
                        {
                            Id = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            Name = "UX/UI Design"
                        },
                        new
                        {
                            Id = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            Name = "Data Engineering"
                        },
                        new
                        {
                            Id = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            Name = "Data Science"
                        },
                        new
                        {
                            Id = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            Name = "AI Engineering"
                        },
                        new
                        {
                            Id = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            Name = "Mobile Engineering"
                        });
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.JobLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JobLevels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f"),
                            Name = "Junior"
                        },
                        new
                        {
                            Id = new Guid("95f75860-d1fd-4956-855c-21fb64284caf"),
                            Name = "Mid"
                        },
                        new
                        {
                            Id = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071"),
                            Name = "Senior"
                        },
                        new
                        {
                            Id = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197"),
                            Name = "Lead"
                        },
                        new
                        {
                            Id = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c"),
                            Name = "Architect"
                        });
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.JobRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("JobAreaId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("JobLevelId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("JobAreaId");

                    b.HasIndex("JobLevelId");

                    b.ToTable("JobRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6aa646f9-0751-41bb-8c0f-7744113fb0ec"),
                            JobAreaId = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("ba3a8eef-bc71-4aaa-a318-c3f5a18b7f74"),
                            JobAreaId = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("f57d72d1-ac23-4ce9-a801-f66075e93bd1"),
                            JobAreaId = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("c27c793f-ea43-4190-8fc1-49d71081c70c"),
                            JobAreaId = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("b70da789-9dad-411e-b9a6-a8ec6be7d095"),
                            JobAreaId = new Guid("df90241d-1427-4b93-9a98-bd48668b467b"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("44e852bc-52c0-40ee-90db-1797d3338b1c"),
                            JobAreaId = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("20badd08-5ede-46dc-a4b1-1b134b3c71ef"),
                            JobAreaId = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("770aba77-fce1-4b3d-b28d-9b57d09ed803"),
                            JobAreaId = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("44abc3ce-f4e1-4f22-863e-fbf8ee0a696a"),
                            JobAreaId = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("f702a4ba-97e1-4947-9582-6183e64cbb24"),
                            JobAreaId = new Guid("96143222-c40e-4d26-bf27-da99fdfe3137"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("38178e08-9cef-4803-93a6-60095c21be05"),
                            JobAreaId = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("4ed640a9-099b-4468-b5a1-79da4505e051"),
                            JobAreaId = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("176671f3-68d5-4573-88a7-aae2892ba269"),
                            JobAreaId = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("64209e5a-d232-4759-b8ff-15d64d77afd9"),
                            JobAreaId = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("a04b77bc-4f4b-4565-be88-3ea714593e87"),
                            JobAreaId = new Guid("364681f4-48ed-4db3-9883-b4757ce482bc"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("d14dd217-6bb9-4267-835b-01164e1acd8c"),
                            JobAreaId = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("b68e12d7-8148-4a15-89f2-9659ea91000a"),
                            JobAreaId = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("318d1c22-3d7c-4516-a4c1-bef951f2e1a7"),
                            JobAreaId = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("19da607b-4368-4824-9fd2-5b6e1b6f3a84"),
                            JobAreaId = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("bf33e555-bfb4-431a-beae-06223bc6cf22"),
                            JobAreaId = new Guid("48dd9750-b3ef-4ac6-bb6a-cff1e0746a20"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("bedd8ad6-b58b-42d2-b975-98d6f0797ccb"),
                            JobAreaId = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("ecdea35d-131c-4e85-a386-13338713e70f"),
                            JobAreaId = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("d5f97718-196f-4961-b5c9-a165798a179b"),
                            JobAreaId = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("054e138b-62cc-4602-b629-b480e4941552"),
                            JobAreaId = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("ebfe74a2-7cd0-48e5-96d9-80e2b05c8122"),
                            JobAreaId = new Guid("2d289858-8a8c-4a3c-a6ab-dc87627fc501"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("81642ba0-f6ae-4a11-85bc-2e4226e3f4aa"),
                            JobAreaId = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("446dfbac-29f2-4df4-b05b-ac1641904347"),
                            JobAreaId = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("2791f705-a407-492b-a04f-42d70598dba9"),
                            JobAreaId = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("8b77add5-e75a-4fe3-a137-f123116af0d9"),
                            JobAreaId = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("9401cedd-3c81-44ee-80f6-5c71c0d57bf5"),
                            JobAreaId = new Guid("3416bc50-eb9c-4185-833e-bf7fd8eedb61"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("067f23ab-7d41-47a3-a2df-d230e77da5d8"),
                            JobAreaId = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("6a94a84b-7dba-4bc9-bb16-84f8505bcf22"),
                            JobAreaId = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("b16bf367-4ab2-4f5c-925c-70f5ea9cc4ad"),
                            JobAreaId = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("13e4db86-9ad6-4e8e-ae64-7ea59b92d5cf"),
                            JobAreaId = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("e10ebb02-829a-4b82-968f-58c8cae88b34"),
                            JobAreaId = new Guid("e8142c80-9123-4b5a-b454-b3f687669d3c"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("53a23ffc-fa52-47a0-9fac-cbd69e5d1898"),
                            JobAreaId = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("137d44f9-0e1c-4e2d-a34a-3392ab1a7463"),
                            JobAreaId = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("0d0878aa-6b59-45c5-b0d8-45be1165cc42"),
                            JobAreaId = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("da6884a7-f348-47ce-b954-004e171cf3c5"),
                            JobAreaId = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("d1028d05-4757-44f3-9948-3358e64271b7"),
                            JobAreaId = new Guid("41859a58-54a1-4795-9d42-fb7946990456"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("2707a397-3893-479d-9ac1-25d850059bee"),
                            JobAreaId = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("a717fcf2-c14f-4c73-be2d-bd587c6f0238"),
                            JobAreaId = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("f3d84dd5-96f2-4e26-97b3-95c2668170e5"),
                            JobAreaId = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("3f06e4cb-012f-4cba-9623-fce8b9f21969"),
                            JobAreaId = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("82c5bfcf-a2b3-4a27-b3da-55dbd2026dee"),
                            JobAreaId = new Guid("40421aca-5df8-494f-a335-56549630e530"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("8f9f98a3-a950-4cb5-8f3a-c775addc1fb3"),
                            JobAreaId = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("de407f9e-63d0-4ad0-a691-fb672bec85bb"),
                            JobAreaId = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("8fbc6740-9b73-424b-9208-9d9ccb039081"),
                            JobAreaId = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("fbd1ffeb-aebb-4448-8b9e-e20260470487"),
                            JobAreaId = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("4219939f-4065-45fc-a17a-31a774300d15"),
                            JobAreaId = new Guid("0c7baf1d-a54b-493e-be77-9356c30133ca"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        },
                        new
                        {
                            Id = new Guid("8b4f2618-eafe-4de9-9c29-3e21148450fa"),
                            JobAreaId = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            JobLevelId = new Guid("2968646f-8af6-4385-8ffb-f480f91ce71f")
                        },
                        new
                        {
                            Id = new Guid("bdfc9a95-9da7-4540-9311-381fe535d606"),
                            JobAreaId = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            JobLevelId = new Guid("95f75860-d1fd-4956-855c-21fb64284caf")
                        },
                        new
                        {
                            Id = new Guid("a91f398e-f29d-4af6-b86c-23762eee1885"),
                            JobAreaId = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            JobLevelId = new Guid("0ffa6c99-d4df-4f1b-8be4-ac4e7f45a071")
                        },
                        new
                        {
                            Id = new Guid("93ea795a-974d-4b11-a85a-aa01dfa7aed1"),
                            JobAreaId = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            JobLevelId = new Guid("d86b90e1-7de8-44f8-b56b-c83b558fa197")
                        },
                        new
                        {
                            Id = new Guid("99491640-52bb-414b-89aa-1c2237e9882c"),
                            JobAreaId = new Guid("c5e9a7d5-8d03-47dd-918f-23ca0c85235d"),
                            JobLevelId = new Guid("1d603409-c561-41c8-ab04-8d389ed7fa4c")
                        });
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.SkillLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SkillLevel");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserHardSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SkillLevelId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ValidtionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SkillLevelId");

                    b.HasIndex("UserProfileId");

                    b.HasIndex("ValidtionId");

                    b.ToTable("HardSkills");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CurrentJobRoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EducationLevelId")
                        .HasColumnType("uuid");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("FutureJobRoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CurrentJobRoleId");

                    b.HasIndex("EducationLevelId");

                    b.HasIndex("FutureJobRoleId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserSoftSkill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SkillLevelId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserProfileId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ValidtionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SkillLevelId");

                    b.HasIndex("UserProfileId");

                    b.HasIndex("ValidtionId");

                    b.ToTable("SoftSkills");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.Validation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ValidationTypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Validation");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.JobRole", b =>
                {
                    b.HasOne("CareerPathCore.Domain.Entities.JobArea", "JobArea")
                        .WithMany()
                        .HasForeignKey("JobAreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.JobLevel", "JobLevel")
                        .WithMany()
                        .HasForeignKey("JobLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JobArea");

                    b.Navigation("JobLevel");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserHardSkill", b =>
                {
                    b.HasOne("CareerPathCore.Domain.Entities.SkillLevel", "SkillLevel")
                        .WithMany()
                        .HasForeignKey("SkillLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.UserProfile", "UserProfile")
                        .WithMany("HardSkills")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.Validation", "Validation")
                        .WithMany()
                        .HasForeignKey("ValidtionId");

                    b.Navigation("SkillLevel");

                    b.Navigation("UserProfile");

                    b.Navigation("Validation");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserProfile", b =>
                {
                    b.HasOne("CareerPathCore.Domain.Entities.JobRole", "CurrentJobRole")
                        .WithMany()
                        .HasForeignKey("CurrentJobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.EducationLevel", "EducationLevel")
                        .WithMany()
                        .HasForeignKey("EducationLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.JobRole", "FutureJobRole")
                        .WithMany()
                        .HasForeignKey("FutureJobRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("CareerPathCore.Domain.Entities.UserProfile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentJobRole");

                    b.Navigation("EducationLevel");

                    b.Navigation("FutureJobRole");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserSoftSkill", b =>
                {
                    b.HasOne("CareerPathCore.Domain.Entities.SkillLevel", "SkillLevel")
                        .WithMany()
                        .HasForeignKey("SkillLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.UserProfile", "UserProfile")
                        .WithMany("SoftSkills")
                        .HasForeignKey("UserProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CareerPathCore.Domain.Entities.Validation", "Validation")
                        .WithMany()
                        .HasForeignKey("ValidtionId");

                    b.Navigation("SkillLevel");

                    b.Navigation("UserProfile");

                    b.Navigation("Validation");
                });

            modelBuilder.Entity("CareerPathCore.Domain.Entities.UserProfile", b =>
                {
                    b.Navigation("HardSkills");

                    b.Navigation("SoftSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
