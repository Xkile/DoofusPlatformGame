using System;

[System.Serializable]
public class jsonDataClass
{
    public player_stats player_data;
    public pulpit_timeInfo pulpit_data;
}

[System.Serializable]
public class player_stats
{
    public int speed;
}

[System.Serializable]
public class pulpit_timeInfo
{
    public float min_pulpit_destroy_time;
    public float max_pulpit_destroy_time;
    public float pulpit_spawn_time;
}




