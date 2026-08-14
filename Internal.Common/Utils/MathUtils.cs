using System.Globalization;

namespace OpenShock.Internal.Common.Utils;

public static class MathUtils
{
    private const float EarthRadius = 6371f;
    private const float DegToRad = MathF.PI / 180f;
    
    /// <summary>
    /// Calculates the distance between two points on the Earth's surface using the Haversine formula.
    /// </summary>
    /// <param name="lat1"></param>
    /// <param name="lon1"></param>
    /// <param name="lat2"></param>
    /// <param name="lon2"></param>
    /// <returns></returns>
    public static float CalculateHaversineDistance(float lat1, float lon1, float lat2, float lon2)
    {

        float latDist = (lat2 - lat1) * DegToRad;
        float lonDist = (lon2 - lon1) * DegToRad;

        float latVal = MathF.Sin(latDist / 2f);
        float lonVal = MathF.Sin(lonDist / 2f);
        float otherVal = MathF.Cos(lat1 * DegToRad) * MathF.Cos(lat2 * DegToRad);

        float a = latVal * latVal + otherVal * (lonVal * lonVal);
        float b = 2f * MathF.Atan2(MathF.Sqrt(a), MathF.Sqrt(1f - a));

        return EarthRadius * b;
    }

    /// <summary>
    /// Linearly interpolates between <paramref name="min"/> and <paramref name="max"/>. <paramref name="t"/> is not clamped.
    /// </summary>
    public static float LerpFloat(float min, float max, float t) => min + (max - min) * t;

    /// <summary>
    /// Linearly interpolates between <paramref name="min"/> and <paramref name="max"/>. <paramref name="t"/> is not clamped.
    /// </summary>
    public static uint LerpUShort(ushort min, ushort max, float t) => (ushort)(min + (max - min) * t);

    /// <summary>
    /// Clamps <paramref name="value"/> to the inclusive range [0, 1].
    /// </summary>
    public static float Saturate(float value) => value < 0 ? 0 : value > 1 ? 1 : value;

    /// <summary>
    /// Clamps <paramref name="value"/> to the inclusive range [<paramref name="min"/>, <paramref name="max"/>].
    /// </summary>
    public static uint ClampUint(uint value, uint min, uint max) => value < min ? min : value > max ? max : value;

    /// <summary>
    /// Clamps <paramref name="value"/> to the inclusive range [<paramref name="min"/>, <paramref name="max"/>].
    /// </summary>
    public static ushort ClampUShort(ushort value, ushort min, ushort max) => value < min ? min : value > max ? max : value;

    /// <summary>
    /// Clamps <paramref name="value"/> to the inclusive range [<paramref name="min"/>, <paramref name="max"/>].
    /// </summary>
    public static byte ClampByte(byte value, byte min, byte max) => value < min ? min : value > max ? max : value;

    /// <summary>
    /// Converts a duration in milliseconds to seconds, rounded to one decimal place.
    /// </summary>
    public static float DurationInSeconds(this uint duration) => MathF.Round(duration / 1000f, 1);

    /// <summary>
    /// Converts a duration in milliseconds to a culture invariant seconds string, rounded to one decimal place.
    /// </summary>
    public static string DurationInSecondsString(this uint duration) =>
        DurationInSeconds(duration).ToString(CultureInfo.InvariantCulture);
}
