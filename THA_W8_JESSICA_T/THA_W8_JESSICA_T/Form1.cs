using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W8_JESSICA_T
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dtTeamName = new DataTable();
        DataTable dtPlayerName = new DataTable();
        DataTable dtmatch = new DataTable();
        DataTable dataPilihan = new DataTable();
        DataTable dataplayers = new DataTable();
        DataTable dtMatchDetails = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Player Name: " + "\n\n" + "Team Name: " + "\n\n" + "Player Position: " + "\n\n" + "Player Nationality: " + "\n\n" + "Player Number: " + "\n\n" + "Yellow Cards: " + "\n\n" +
                "Red Cards: " + "\n\n" + "Goal Scored: " + "\n\n" + "Penalty Missed: " + "\n\n";

            connectionString = "server=localhost;uid=root;pwd=Njmborahae11!;database=premier_league";
            conn = new MySqlConnection(connectionString);

            sqlQuery = "SELECT team_name, team_id FROM team;";
            sqlCommand = new MySqlCommand(sqlQuery, conn);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamName);
            comboBox_Teams.DataSource = dtTeamName;
            comboBox_Teams.DisplayMember = "team_name";
            comboBox_Teams.ValueMember = "team_id";
        }

        private void showMatchDetails(bool hhee)
        {
            label4.Visible = hhee;
            label5.Visible = hhee;
            label6.Visible = hhee;
            dataGridView_away.Visible = hhee;
            dataGridView_home.Visible = hhee;
            dataGridView_MatchDetails.Visible = hhee;
        }
        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox_Players.DataSource = dtPlayerName;
            label3.Text = "Player Name: " + "\n\n" + "Team Name: " + "\n\n" + "Player Position: " + "\n\n" + "Player Nationality: " + "\n\n" + "Player Number: " + "\n\n" + "Yellow Cards: " + "\n\n" +
                "Red Cards: " + "\n\n" + "Goal Scored: " + "\n\n" + "Penalty Missed: " + "\n\n";
            showMatchDetails(false);
            comboBox_Teams.SelectedValue = " ";

            comboBox_Players.SelectedValue = " ";
            label2.Text = "Choose Player";

            dataGridView_away.DataSource = null;
            dataGridView_away.Rows.Clear();

            dataGridView_home.DataSource = null;
            dataGridView_home.Rows.Clear();

            dataGridView_MatchDetails.DataSource = null;
            dataGridView_MatchDetails.Rows.Clear();
        }

        private void comboBox_Teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label2.Text == "Choose Player")
            {
                dtPlayerName = new DataTable();
                sqlQuery = "SELECT p.player_name as `Player Name` FROM player p INNER JOIN team t ON p.team_id = t.team_id AND t.team_id = '" + comboBox_Teams.SelectedValue + "';";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPlayerName);
                comboBox_Players.DataSource = dtPlayerName;
                comboBox_Players.ValueMember = "Player Name";
                comboBox_Players.SelectedValue = " ";
            }
            else
            {
                dtmatch = new DataTable();
                sqlQuery = "SELECT concat(t.team_name, \" vs \", t2.team_name) as 'Match', match_id FROM `match` ma INNER JOIN premier_league.referee r ON r.referee_id = ma.referee_id LEFT JOIN premier_league.team t ON ma.team_away = t.team_id LEFT JOIN premier_league.team t2 ON ma.team_home = t2.team_id WHERE t.team_id LIKE '" + comboBox_Teams.SelectedValue + "' OR t2.team_id LIKE '" + comboBox_Teams.SelectedValue +"'";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtmatch);
                comboBox_Players.DataSource = dtmatch;
                comboBox_Players.DisplayMember = "Match";
                comboBox_Players.ValueMember = "match_id";
                comboBox_Players.SelectedValue = " ";
            }
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showMatchDetails(true);
            label3.Text = " ";
            comboBox_Players.DataSource = dtmatch;
            label2.Text = "Choose Match";
            comboBox_Players.SelectedValue = " ";
            comboBox_Teams.SelectedValue = " ";
        }

        private void comboBox_Players_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            if (label2.Text == "Choose Player")
            {
                dataPilihan = new DataTable();
                sqlQuery = "SELECT p.player_name AS 'Player Name', t.team_name AS 'Team', p.playing_pos AS 'Position', n.nation AS 'Nationality', p.team_number AS 'Player Number' ," +
                    "sum(if(type = 'CY', 1,0)) AS 'Yellow Cards', sum(if(type = 'CR',1,0)) AS 'Red Cards', sum(if(type = 'GO',1,0)) AS 'Goal Scored', sum(if(type = 'PM',1,0)) AS 'Penalty Missed'" +
                    "\r\nFROM player p\r\nINNER JOIN nationality n ON p.nationality_id = n.nationality_id\r\nINNER JOIN team t ON t.team_id = p.team_id \r\nLEFT JOIN dmatch d ON p.player_id = d.player_id\r\n WHERE p.player_name = '" + comboBox_Players.SelectedValue + "' GROUP BY 1, 2, 3, 4, 5;";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataPilihan);

                string data = "";
                foreach (DataRow row in dataPilihan.Rows)
                {
                    data += "Player Name: " + row["Player Name"].ToString() + "\n\n" +
                            "Team Name: " + row["Team"].ToString() + "\n\n" +
                            "Player Position: " + row["Position"].ToString() + "\n\n" +
                            "Player Nationality: " + row["Nationality"].ToString() + "\n\n" +
                            "Player Number: " + row["Player Number"].ToString() + "\n\n" +
                            "Yellow Cards: " + row["Yellow Cards"].ToString() + "\n\n" +
                            "Red Cards: " + row["Red Cards"].ToString() + "\n\n" +
                            "Goal Scored: " + row["Goal Scored"].ToString() + "\n\n" +
                            "Penalty Missed: " + row["Penalty Missed"].ToString() + "\n\n";
                }
                label3.Text = data;
            }
            else
            {
                var selectedItem = comboBox_Players.SelectedItem;
                var selectedDataRowView = (DataRowView)selectedItem;
                var displayMemberValue = selectedDataRowView.Row["Match"].ToString();
                string ho = displayMemberValue;
                string[] split = ho.Split(new string[] { " vs " }, StringSplitOptions.None);
                string hometeam = split[0];
                string awayteam = split[1];

                dataplayers = new DataTable();
                sqlQuery = "SELECT t.team_name AS 'Team Name', p.player_name AS 'Player Name' ,  p.playing_pos AS 'Position'\r\nFROM team t , player p\r\nWHERE t.team_id = p.team_id\r\nAND t.team_name = '" + hometeam + "';";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataplayers);
                dataGridView_home.DataSource = dataplayers;

                dataPilihan = new DataTable();
                sqlQuery = "SELECT t.team_name AS 'Team Name', p.player_name AS 'Player Name' ,  p.playing_pos AS 'Position'\r\nFROM team t , player p\r\nWHERE t.team_id = p.team_id\r\nAND t.team_name = '" + awayteam + "';";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataPilihan);
                dataGridView_away.DataSource = dataPilihan;

                dtMatchDetails = new DataTable();
                sqlQuery = "SELECT d.minute AS 'Minute', t.team_name AS 'Team Name' , p.player_name AS 'Player Name', if(d.type = 'CY' ,'Yellow Card', if(d.type = 'GO', 'Goal', if(d.type = 'GW', 'Own Goal', if(d.type = 'CR', 'Red Card', if(d.type = 'PM', 'Penalty Miss', 'Goal Penalty'))))) AS 'Type' \r\nFROM dmatch d, team t, player p WHERE d.team_id = t.team_id and p.player_id = d.player_id AND d.match_id = '" + comboBox_Players.SelectedValue + "';";
                sqlCommand = new MySqlCommand(sqlQuery, conn);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMatchDetails);
                dataGridView_MatchDetails.DataSource = dtMatchDetails;
            }
        }
    }
}
