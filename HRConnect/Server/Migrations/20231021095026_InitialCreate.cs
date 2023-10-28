using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRConnect.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documenti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipologiaSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HRs",
                columns: table => new
                {
                    HRId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRs", x => x.HRId);
                });

            migrationBuilder.CreateTable(
                name: "LivelliContrattuali",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Livello = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelliContrattuali", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mansioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansioni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipologiaSkill = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipologiaTitolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedi",
                columns: table => new
                {
                    SedeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recapito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedi", x => x.SedeId);
                    table.ForeignKey(
                        name: "FK_Sedi_HRs_HRId",
                        column: x => x.HRId,
                        principalTable: "HRs",
                        principalColumn: "HRId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contratti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoContratto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LivelloContrattualeID = table.Column<int>(type: "int", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeID",
                        column: x => x.LivelloContrattualeID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HardSkillLivelloContrattuale",
                columns: table => new
                {
                    HardSkillsId = table.Column<int>(type: "int", nullable: false),
                    LivelliContrattualiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkillLivelloContrattuale", x => new { x.HardSkillsId, x.LivelliContrattualiID });
                    table.ForeignKey(
                        name: "FK_HardSkillLivelloContrattuale_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardSkillLivelloContrattuale_LivelliContrattuali_LivelliContrattualiID",
                        column: x => x.LivelliContrattualiID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivelloContrattualeSoftSkill",
                columns: table => new
                {
                    DescrizioneLavoriID = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelloContrattualeSoftSkill", x => new { x.DescrizioneLavoriID, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_LivelloContrattualeSoftSkill_LivelliContrattuali_DescrizioneLavoriID",
                        column: x => x.DescrizioneLavoriID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivelloContrattualeSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citta_Sedi_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sedi",
                        principalColumn: "SedeId");
                });

            migrationBuilder.CreateTable(
                name: "Dipendenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContrattoId = table.Column<int>(type: "int", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true),
                    LivelliContrattualiID = table.Column<int>(type: "int", nullable: true),
                    MansioneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dipendenti_Contratti_ContrattoId",
                        column: x => x.ContrattoId,
                        principalTable: "Contratti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dipendenti_LivelliContrattuali_LivelliContrattualiID",
                        column: x => x.LivelliContrattualiID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Dipendenti_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dipendenti_Sedi_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sedi",
                        principalColumn: "SedeId");
                });

            migrationBuilder.CreateTable(
                name: "Candidati",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComuneDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinciaDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatoDiNascita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CittaId = table.Column<int>(type: "int", nullable: true),
                    DocumentoID = table.Column<int>(type: "int", nullable: false),
                    ContrattoId = table.Column<int>(type: "int", nullable: true),
                    TitoloDiStudioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidati_Citta_CittaId",
                        column: x => x.CittaId,
                        principalTable: "Citta",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidati_Contratti_ContrattoId",
                        column: x => x.ContrattoId,
                        principalTable: "Contratti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Candidati_Documenti_DocumentoID",
                        column: x => x.DocumentoID,
                        principalTable: "Documenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidati_TitoliDiStudio_TitoloDiStudioId",
                        column: x => x.TitoloDiStudioId,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BenefitDipendente",
                columns: table => new
                {
                    BenefitsId = table.Column<int>(type: "int", nullable: false),
                    DipendentiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitDipendente", x => new { x.BenefitsId, x.DipendentiId });
                    table.ForeignKey(
                        name: "FK_BenefitDipendente_Benefits_BenefitsId",
                        column: x => x.BenefitsId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BenefitDipendente_Dipendenti_DipendentiId",
                        column: x => x.DipendentiId,
                        principalTable: "Dipendenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DipendenteHardSkill",
                columns: table => new
                {
                    DipendentiId = table.Column<int>(type: "int", nullable: false),
                    HardSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DipendenteHardSkill", x => new { x.DipendentiId, x.HardSkillsId });
                    table.ForeignKey(
                        name: "FK_DipendenteHardSkill_Dipendenti_DipendentiId",
                        column: x => x.DipendentiId,
                        principalTable: "Dipendenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DipendenteHardSkill_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DipendenteSoftSkill",
                columns: table => new
                {
                    DipendentiId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DipendenteSoftSkill", x => new { x.DipendentiId, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_DipendenteSoftSkill_Dipendenti_DipendentiId",
                        column: x => x.DipendentiId,
                        principalTable: "Dipendenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DipendenteSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoHardSkill",
                columns: table => new
                {
                    CandidatiId = table.Column<int>(type: "int", nullable: false),
                    HardSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoHardSkill", x => new { x.CandidatiId, x.HardSkillsId });
                    table.ForeignKey(
                        name: "FK_CandidatoHardSkill_Candidati_CandidatiId",
                        column: x => x.CandidatiId,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoHardSkill_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatoSoftSkill",
                columns: table => new
                {
                    CandidatiId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatoSoftSkill", x => new { x.CandidatiId, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_CandidatoSoftSkill_Candidati_CandidatiId",
                        column: x => x.CandidatiId,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatoSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colloqui",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataColloquio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CandidatoId = table.Column<int>(type: "int", nullable: true),
                    HRId = table.Column<int>(type: "int", nullable: true),
                    SedeId = table.Column<int>(type: "int", nullable: true),
                    Valutazione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidatiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colloqui", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colloqui_Candidati_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Colloqui_HRs_HRId",
                        column: x => x.HRId,
                        principalTable: "HRs",
                        principalColumn: "HRId");
                    table.ForeignKey(
                        name: "FK_Colloqui_Sedi_SedeId",
                        column: x => x.SedeId,
                        principalTable: "Sedi",
                        principalColumn: "SedeId");
                });

            migrationBuilder.CreateTable(
                name: "EsperienzeLavorative",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MansioneId = table.Column<int>(type: "int", nullable: true),
                    Azienda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContrattoId = table.Column<int>(type: "int", nullable: true),
                    CandidatoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsperienzeLavorative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EsperienzeLavorative_Candidati_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EsperienzeLavorative_Contratti_ContrattoId",
                        column: x => x.ContrattoId,
                        principalTable: "Contratti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EsperienzeLavorative_Mansioni_MansioneId",
                        column: x => x.MansioneId,
                        principalTable: "Mansioni",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefitDipendente_DipendentiId",
                table: "BenefitDipendente",
                column: "DipendentiId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_CittaId",
                table: "Candidati",
                column: "CittaId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_ContrattoId",
                table: "Candidati",
                column: "ContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_DocumentoID",
                table: "Candidati",
                column: "DocumentoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_TitoloDiStudioId",
                table: "Candidati",
                column: "TitoloDiStudioId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoHardSkill_HardSkillsId",
                table: "CandidatoHardSkill",
                column: "HardSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatoSoftSkill_SoftSkillsId",
                table: "CandidatoSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Citta_SedeId",
                table: "Citta",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_CandidatoId",
                table: "Colloqui",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_HRId",
                table: "Colloqui",
                column: "HRId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_SedeId",
                table: "Colloqui",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_LivelloContrattualeID",
                table: "Contratti",
                column: "LivelloContrattualeID");

            migrationBuilder.CreateIndex(
                name: "IX_DipendenteHardSkill_HardSkillsId",
                table: "DipendenteHardSkill",
                column: "HardSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_DipendenteSoftSkill_SoftSkillsId",
                table: "DipendenteSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_ContrattoId",
                table: "Dipendenti",
                column: "ContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_LivelliContrattualiID",
                table: "Dipendenti",
                column: "LivelliContrattualiID");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_MansioneId",
                table: "Dipendenti",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_SedeId",
                table: "Dipendenti",
                column: "SedeId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_CandidatoId",
                table: "EsperienzeLavorative",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_ContrattoId",
                table: "EsperienzeLavorative",
                column: "ContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_EsperienzeLavorative_MansioneId",
                table: "EsperienzeLavorative",
                column: "MansioneId");

            migrationBuilder.CreateIndex(
                name: "IX_HardSkillLivelloContrattuale_LivelliContrattualiID",
                table: "HardSkillLivelloContrattuale",
                column: "LivelliContrattualiID");

            migrationBuilder.CreateIndex(
                name: "IX_LivelloContrattualeSoftSkill_SoftSkillsId",
                table: "LivelloContrattualeSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Sedi_HRId",
                table: "Sedi",
                column: "HRId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenefitDipendente");

            migrationBuilder.DropTable(
                name: "CandidatoHardSkill");

            migrationBuilder.DropTable(
                name: "CandidatoSoftSkill");

            migrationBuilder.DropTable(
                name: "Colloqui");

            migrationBuilder.DropTable(
                name: "DipendenteHardSkill");

            migrationBuilder.DropTable(
                name: "DipendenteSoftSkill");

            migrationBuilder.DropTable(
                name: "EsperienzeLavorative");

            migrationBuilder.DropTable(
                name: "HardSkillLivelloContrattuale");

            migrationBuilder.DropTable(
                name: "LivelloContrattualeSoftSkill");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Dipendenti");

            migrationBuilder.DropTable(
                name: "Candidati");

            migrationBuilder.DropTable(
                name: "HardSkills");

            migrationBuilder.DropTable(
                name: "SoftSkills");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "Citta");

            migrationBuilder.DropTable(
                name: "Contratti");

            migrationBuilder.DropTable(
                name: "Documenti");

            migrationBuilder.DropTable(
                name: "TitoliDiStudio");

            migrationBuilder.DropTable(
                name: "Sedi");

            migrationBuilder.DropTable(
                name: "LivelliContrattuali");

            migrationBuilder.DropTable(
                name: "HRs");
        }
    }
}
