using OpenShock.Internal.Common.Utils;

namespace OpenShock.Internal.Common.Tests.Utils;

public class MathUtilsTests
{
    [Test]
    public async Task SamePoint_ReturnsZero()
    {
        var result = MathUtils.CalculateHaversineDistance(0f, 0f, 0f, 0f);
        await Assert.That(result).IsEqualTo(0f);
    }

    [Test]
    public async Task SameCoordinates_ReturnsZero()
    {
        var result = MathUtils.CalculateHaversineDistance(52.52f, 13.405f, 52.52f, 13.405f);
        await Assert.That(result).IsEqualTo(0f);
    }

    [Test]
    public async Task NewYork_To_London_ApproximatelyCorrect()
    {
        // NYC: 40.7128, -74.0060  London: 51.5074, -0.1278
        // Expected: ~5570 km
        var result = MathUtils.CalculateHaversineDistance(40.7128f, -74.006f, 51.5074f, -0.1278f);
        await Assert.That(result).IsGreaterThan(5500f);
        await Assert.That(result).IsLessThan(5650f);
    }

    [Test]
    public async Task NorthPole_To_SouthPole_ApproximatelyHalfCircumference()
    {
        // ~20015 km
        var result = MathUtils.CalculateHaversineDistance(90f, 0f, -90f, 0f);
        await Assert.That(result).IsGreaterThan(19900f);
        await Assert.That(result).IsLessThan(20100f);
    }

    [Test]
    public async Task Equator_QuarterWayAround_ApproximatelyCorrect()
    {
        // 0,0 to 0,90 — quarter circumference at equator ~10008 km
        var result = MathUtils.CalculateHaversineDistance(0f, 0f, 0f, 90f);
        await Assert.That(result).IsGreaterThan(9900f);
        await Assert.That(result).IsLessThan(10100f);
    }

    [Test]
    public async Task IsSymmetric()
    {
        var ab = MathUtils.CalculateHaversineDistance(48.8566f, 2.3522f, 35.6762f, 139.6503f);
        var ba = MathUtils.CalculateHaversineDistance(35.6762f, 139.6503f, 48.8566f, 2.3522f);
        await Assert.That(MathF.Abs(ab - ba)).IsLessThan(0.01f);
    }

    [Test]
    public async Task AntipodalPoints_ApproximatelyHalfCircumference()
    {
        // 0,0 to 0,180 — half circumference ~20015 km
        var result = MathUtils.CalculateHaversineDistance(0f, 0f, 0f, 180f);
        await Assert.That(result).IsGreaterThan(19900f);
        await Assert.That(result).IsLessThan(20100f);
    }

    [Test]
    [Arguments(0f, 10f, 0f, 0f)]
    [Arguments(0f, 10f, 1f, 10f)]
    [Arguments(0f, 10f, 0.5f, 5f)]
    [Arguments(-10f, 10f, 0.5f, 0f)]
    [Arguments(5f, 5f, 0.7f, 5f)]
    public async Task LerpFloat_InterpolatesLinearly(float min, float max, float t, float expected)
    {
        await Assert.That(MathUtils.LerpFloat(min, max, t)).IsEqualTo(expected).Within(0.0001f);
    }

    [Test]
    public async Task LerpFloat_DoesNotClampT()
    {
        await Assert.That(MathUtils.LerpFloat(0f, 10f, 2f)).IsEqualTo(20f).Within(0.0001f);
        await Assert.That(MathUtils.LerpFloat(0f, 10f, -1f)).IsEqualTo(-10f).Within(0.0001f);
    }

    [Test]
    [Arguments((ushort)0, (ushort)100, 0f, 0u)]
    [Arguments((ushort)0, (ushort)100, 1f, 100u)]
    [Arguments((ushort)0, (ushort)100, 0.5f, 50u)]
    [Arguments((ushort)10, (ushort)20, 0.25f, 12u)]
    public async Task LerpUShort_InterpolatesLinearly(ushort min, ushort max, float t, uint expected)
    {
        await Assert.That(MathUtils.LerpUShort(min, max, t)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(-1f, 0f)]
    [Arguments(0f, 0f)]
    [Arguments(0.5f, 0.5f)]
    [Arguments(1f, 1f)]
    [Arguments(2f, 1f)]
    public async Task Saturate_ClampsToUnitRange(float value, float expected)
    {
        await Assert.That(MathUtils.Saturate(value)).IsEqualTo(expected).Within(0.0001f);
    }

    [Test]
    [Arguments(5u, 10u, 20u, 10u)]
    [Arguments(25u, 10u, 20u, 20u)]
    [Arguments(15u, 10u, 20u, 15u)]
    [Arguments(10u, 10u, 20u, 10u)]
    [Arguments(20u, 10u, 20u, 20u)]
    public async Task ClampUint_ClampsToRange(uint value, uint min, uint max, uint expected)
    {
        await Assert.That(MathUtils.ClampUint(value, min, max)).IsEqualTo(expected);
    }

    [Test]
    [Arguments((ushort)5, (ushort)10, (ushort)20, (ushort)10)]
    [Arguments((ushort)25, (ushort)10, (ushort)20, (ushort)20)]
    [Arguments((ushort)15, (ushort)10, (ushort)20, (ushort)15)]
    public async Task ClampUShort_ClampsToRange(ushort value, ushort min, ushort max, ushort expected)
    {
        await Assert.That(MathUtils.ClampUShort(value, min, max)).IsEqualTo(expected);
    }

    [Test]
    [Arguments((byte)5, (byte)10, (byte)20, (byte)10)]
    [Arguments((byte)25, (byte)10, (byte)20, (byte)20)]
    [Arguments((byte)15, (byte)10, (byte)20, (byte)15)]
    public async Task ClampByte_ClampsToRange(byte value, byte min, byte max, byte expected)
    {
        await Assert.That(MathUtils.ClampByte(value, min, max)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(0u, 0f)]
    [Arguments(1000u, 1f)]
    [Arguments(1500u, 1.5f)]
    [Arguments(300u, 0.3f)]
    [Arguments(1234u, 1.2f)]
    public async Task DurationInSeconds_RoundsToOneDecimal(uint duration, float expected)
    {
        await Assert.That(duration.DurationInSeconds()).IsEqualTo(expected).Within(0.0001f);
    }

    [Test]
    [Arguments(1000u, "1")]
    [Arguments(1500u, "1.5")]
    [Arguments(1234u, "1.2")]
    public async Task DurationInSecondsString_IsCultureInvariant(uint duration, string expected)
    {
        await Assert.That(duration.DurationInSecondsString()).IsEqualTo(expected);
    }
}
