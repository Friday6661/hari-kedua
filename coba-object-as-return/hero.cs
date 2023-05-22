namespace heroLib;

class Hero {
    private Assasins _heroAssasins;
    private Fighter _heroFighters;
    private Tank _heroTanks;
    private int totalHero;

    public Hero(Assasins heroAssasins, Fighter heroFighters, Tank heroTanks) {
        _heroAssasins = heroAssasins;
        _heroFighters = heroFighters;
        _heroTanks = heroTanks;
        
    }
}