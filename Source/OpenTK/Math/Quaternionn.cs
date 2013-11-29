#region --- License ---
/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion

#if HAVE_NATIVE_TYPES

using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OpenTK
{
    /// <summary>
    /// Represents a nfloat-precision Quaternion.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Quaternionn : IEquatable<Quaternionn>
    {
        #region Fields

        Vector3n xyz;
        nfloat w;

        #endregion

        #region Constructors

        /// <summary>
        /// Construct a new Quaternionn from vector and w components
        /// </summary>
        /// <param name="v">The vector part</param>
        /// <param name="w">The w part</param>
        public Quaternionn(Vector3n v, nfloat w)
        {
            this.xyz = v;
            this.w = w;
        }

        /// <summary>
        /// Construct a new Quaternionn
        /// </summary>
        /// <param name="x">The x component</param>
        /// <param name="y">The y component</param>
        /// <param name="z">The z component</param>
        /// <param name="w">The w component</param>
        public Quaternionn(nfloat x, nfloat y, nfloat z, nfloat w)
            : this(new Vector3n(x, y, z), w)
        { }

		public Quaternionn (ref Matrix3n matrix)
		{
			double scale = System.Math.Pow(matrix.Determinant, 1.0d / 3.0d);
			nfloat x, y, z;

			w = (nfloat) (System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] + matrix[1, 1] + matrix[2, 2])) / 2);
			x = (nfloat) (System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] - matrix[1, 1] - matrix[2, 2])) / 2);
			y = (nfloat) (System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] + matrix[1, 1] - matrix[2, 2])) / 2);
			z = (nfloat) (System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] - matrix[1, 1] + matrix[2, 2])) / 2);

			xyz = new Vector3n (x, y, z);

			if (matrix[2, 1] - matrix[1, 2] < 0) X = -X;
			if (matrix[0, 2] - matrix[2, 0] < 0) Y = -Y;
			if (matrix[1, 0] - matrix[0, 1] < 0) Z = -Z;
		}
        #endregion

        #region Public Members

        #region Properties

        /// <summary>
        /// Gets or sets an OpenTK.Vector3n with the X, Y and Z components of this instance.
        /// </summary>
        [Obsolete("Use Xyz property instead.")]
        [CLSCompliant(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [XmlIgnore]
        public Vector3n XYZ { get { return Xyz; } set { Xyz = value; } }

        /// <summary>
        /// Gets or sets an OpenTK.Vector3n with the X, Y and Z components of this instance.
        /// </summary>
        public Vector3n Xyz { get { return xyz; } set { xyz = value; } }

        /// <summary>
        /// Gets or sets the X component of this instance.
        /// </summary>
        [XmlIgnore]
        public nfloat X { get { return xyz.X; } set { xyz.X = value; } }

        /// <summary>
        /// Gets or sets the Y component of this instance.
        /// </summary>
        [XmlIgnore]
        public nfloat Y { get { return xyz.Y; } set { xyz.Y = value; } }

        /// <summary>
        /// Gets or sets the Z component of this instance.
        /// </summary>
        [XmlIgnore]
        public nfloat Z { get { return xyz.Z; } set { xyz.Z = value; } }

        /// <summary>
        /// Gets or sets the W component of this instance.
        /// </summary>
        public nfloat W { get { return w; } set { w = value; } }
        
        #endregion

        #region Instance

        #region ToAxisAngle

        /// <summary>
        /// Convert the current quaternion to axis angle representation
        /// </summary>
        /// <param name="axis">The resultant axis</param>
        /// <param name="angle">The resultant angle</param>
        public void ToAxisAngle(out Vector3n axis, out nfloat angle)
        {
            Vector4n result = ToAxisAngle();
            axis = result.Xyz;
            angle = result.W;
        }

        /// <summary>
        /// Convert this instance to an axis-angle representation.
        /// </summary>
        /// <returns>A Vector4 that is the axis-angle representation of this quaternion.</returns>
        public Vector4n ToAxisAngle()
        {
            Quaternionn q = this;
            if (q.W > 1.0f)
                q.Normalize();

            Vector4n result = new Vector4n();

            result.W = 2.0f * (float)System.Math.Acos(q.W); // angle
            float den = (float)System.Math.Sqrt(1.0 - q.W * q.W);
            if (den > 0.0001f)
            {
                result.Xyz = q.Xyz / den;
            }
            else
            {
                // This occurs when the angle is zero. 
                // Not a problem: just set an arbitrary normalized axis.
                result.Xyz = Vector3n.UnitX;
            }

            return result;
        }

        #endregion

        #region public nfloat Length

        /// <summary>
        /// Gets the length (magnitude) of the Quaternionn.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        public nfloat Length
        {
            get
            {
                return (nfloat)System.Math.Sqrt(W * W + Xyz.LengthSquared);
            }
        }

        #endregion

        #region public nfloat LengthSquared

        /// <summary>
        /// Gets the square of the Quaternionn length (magnitude).
        /// </summary>
        public nfloat LengthSquared
        {
            get
            {
                return W * W + Xyz.LengthSquared;
            }
        }

        #endregion

        #region public void Normalize()

        /// <summary>
        /// Scales the Quaternionn to unit length.
        /// </summary>
        public void Normalize()
        {
            nfloat scale = 1.0f / this.Length;
            Xyz *= scale;
            W *= scale;
        }

        #endregion

        #region public void Conjugate()

        /// <summary>
        /// Convert this Quaternionn to its conjugate
        /// </summary>
        public void Conjugate()
        {
            Xyz = -Xyz;
        }

        #endregion

        #endregion

        #region Static

        #region Fields

        /// <summary>
        /// Defines the identity quaternion.
        /// </summary>
        public readonly static Quaternionn Identity = new Quaternionn(0, 0, 0, 1);

        #endregion

        #region Add

        /// <summary>
        /// Add two quaternions
        /// </summary>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        /// <returns>The result of the addition</returns>
        public static Quaternionn Add(Quaternionn left, Quaternionn right)
        {
            return new Quaternionn(
                left.Xyz + right.Xyz,
                left.W + right.W);
        }

        /// <summary>
        /// Add two quaternions
        /// </summary>
        /// <param name="left">The first operand</param>
        /// <param name="right">The second operand</param>
        /// <param name="result">The result of the addition</param>
        public static void Add(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result = new Quaternionn(
                left.Xyz + right.Xyz,
                left.W + right.W);
        }

        #endregion

        #region Sub

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <returns>The result of the operation.</returns>
        public static Quaternionn Sub(Quaternionn left, Quaternionn right)
        {
            return new Quaternionn(
                left.Xyz - right.Xyz,
                left.W - right.W);
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The left instance.</param>
        /// <param name="right">The right instance.</param>
        /// <param name="result">The result of the operation.</param>
        public static void Sub(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result = new Quaternionn(
                left.Xyz - right.Xyz,
                left.W - right.W);
        }

        #endregion

        #region Mult

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        [Obsolete("Use Multiply instead.")]
        public static Quaternionn Mult(Quaternionn left, Quaternionn right)
        {
            return new Quaternionn(
                right.W * left.Xyz + left.W * right.Xyz + Vector3n.Cross(left.Xyz, right.Xyz),
                left.W * right.W - Vector3n.Dot(left.Xyz, right.Xyz));
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        [Obsolete("Use Multiply instead.")]
        public static void Mult(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result = new Quaternionn(
                right.W * left.Xyz + left.W * right.Xyz + Vector3n.Cross(left.Xyz, right.Xyz),
                left.W * right.W - Vector3n.Dot(left.Xyz, right.Xyz));
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static Quaternionn Multiply(Quaternionn left, Quaternionn right)
        {
            Quaternionn result;
            Multiply(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result = new Quaternionn(
                right.W * left.Xyz + left.W * right.Xyz + Vector3n.Cross(left.Xyz, right.Xyz),
                left.W * right.W - Vector3n.Dot(left.Xyz, right.Xyz));
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(ref Quaternionn quaternion, nfloat scale, out Quaternionn result)
        {
            result = new Quaternionn(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(ref Quaternionn quaternion, ref nfloat scale, out Quaternionn result)
        {
            result = new Quaternionn(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static Quaternionn Multiply(Quaternionn quaternion, nfloat scale)
        {
            return new Quaternionn(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
        }

        #endregion

        #region Conjugate

        /// <summary>
        /// Get the conjugate of the given Quaternionn
        /// </summary>
        /// <param name="q">The Quaternionn</param>
        /// <returns>The conjugate of the given Quaternionn</returns>
        public static Quaternionn Conjugate(Quaternionn q)
        {
            return new Quaternionn(-q.Xyz, q.W);
        }

        /// <summary>
        /// Get the conjugate of the given Quaternionn
        /// </summary>
        /// <param name="q">The Quaternionn</param>
        /// <param name="result">The conjugate of the given Quaternionn</param>
        public static void Conjugate(ref Quaternionn q, out Quaternionn result)
        {
            result = new Quaternionn(-q.Xyz, q.W);
        }

        #endregion

        #region Invert

        /// <summary>
        /// Get the inverse of the given Quaternionn
        /// </summary>
        /// <param name="q">The Quaternionn to invert</param>
        /// <returns>The inverse of the given Quaternionn</returns>
        public static Quaternionn Invert(Quaternionn q)
        {
            Quaternionn result;
            Invert(ref q, out result);
            return result;
        }

        /// <summary>
        /// Get the inverse of the given Quaternionn
        /// </summary>
        /// <param name="q">The Quaternionn to invert</param>
        /// <param name="result">The inverse of the given Quaternionn</param>
        public static void Invert(ref Quaternionn q, out Quaternionn result)
        {
            nfloat lengthSq = q.LengthSquared;
            if (lengthSq != 0.0)
            {
                nfloat i = 1.0f / lengthSq;
                result = new Quaternionn(q.Xyz * -i, q.W * i);
            }
            else
            {
                result = q;
            }
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale the given Quaternionn to unit length
        /// </summary>
        /// <param name="q">The Quaternionn to normalize</param>
        /// <returns>The normalized Quaternionn</returns>
        public static Quaternionn Normalize(Quaternionn q)
        {
            Quaternionn result;
            Normalize(ref q, out result);
            return result;
        }

        /// <summary>
        /// Scale the given Quaternionn to unit length
        /// </summary>
        /// <param name="q">The Quaternionn to normalize</param>
        /// <param name="result">The normalized Quaternionn</param>
        public static void Normalize(ref Quaternionn q, out Quaternionn result)
        {
            nfloat scale = 1.0f / q.Length;
            result = new Quaternionn(q.Xyz * scale, q.W * scale);
        }

        #endregion

        #region FromAxisAngle

        /// <summary>
        /// Build a Quaternionn from the given axis and angle
        /// </summary>
        /// <param name="axis">The axis to rotate about</param>
        /// <param name="angle">The rotation angle in radians</param>
        /// <returns></returns>
        public static Quaternionn FromAxisAngle(Vector3n axis, nfloat angle)
        {
            if (axis.LengthSquared == 0.0f)
                return Identity;

            Quaternionn result = Identity;

            angle *= 0.5f;
            axis.Normalize();
            result.Xyz = axis * (nfloat)System.Math.Sin(angle);
            result.W = (nfloat)System.Math.Cos(angle);

            return Normalize(result);
        }

        #endregion

        #region Slerp

        /// <summary>
        /// Do Spherical linear interpolation between two quaternions 
        /// </summary>
        /// <param name="q1">The first Quaternionn</param>
        /// <param name="q2">The second Quaternionn</param>
        /// <param name="blend">The blend factor</param>
        /// <returns>A smooth blend between the given quaternions</returns>
        public static Quaternionn Slerp(Quaternionn q1, Quaternionn q2, nfloat blend)
        {
            // if either input is zero, return the other.
            if (q1.LengthSquared == 0.0f)
            {
                if (q2.LengthSquared == 0.0f)
                {
                    return Identity;
                }
                return q2;
            }
            else if (q2.LengthSquared == 0.0f)
            {
                return q1;
            }


            nfloat cosHalfAngle = q1.W * q2.W + Vector3n.Dot(q1.Xyz, q2.Xyz);

            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                // angle = 0.0f, so just return one input.
                return q1;
            }
            else if (cosHalfAngle < 0.0f)
            {
                q2.Xyz = -q2.Xyz;
                q2.W = -q2.W;
                cosHalfAngle = -cosHalfAngle;
            }

            nfloat blendA;
            nfloat blendB;
            if (cosHalfAngle < 0.99f)
            {
                // do proper slerp for big angles
                nfloat halfAngle = (nfloat)System.Math.Acos(cosHalfAngle);
                nfloat sinHalfAngle = (nfloat)System.Math.Sin(halfAngle);
                nfloat oneOverSinHalfAngle = 1.0f / sinHalfAngle;
                blendA = (nfloat)System.Math.Sin(halfAngle * (1.0f - blend)) * oneOverSinHalfAngle;
                blendB = (nfloat)System.Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
            }
            else
            {
                // do lerp if angle is really small.
                blendA = 1.0f - blend;
                blendB = blend;
            }

            Quaternionn result = new Quaternionn(blendA * q1.Xyz + blendB * q2.Xyz, blendA * q1.W + blendB * q2.W);
            if (result.LengthSquared > 0.0f)
                return Normalize(result);
            else
                return Identity;
        }

        #endregion

        #endregion
                
        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Quaternionn operator +(Quaternionn left, Quaternionn right)
        {
            left.Xyz += right.Xyz;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Quaternionn operator -(Quaternionn left, Quaternionn right)
        {
            left.Xyz -= right.Xyz;
            left.W -= right.W;
            return left;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static Quaternionn operator *(Quaternionn left, Quaternionn right)
        {
            Multiply(ref left, ref right, out left);
            return left;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static Quaternionn operator *(Quaternionn quaternion, nfloat scale)
        {
            Multiply(ref quaternion, scale, out quaternion);
            return quaternion;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static Quaternionn operator *(nfloat scale, Quaternionn quaternion)
        {
            return new Quaternionn(quaternion.X * scale, quaternion.Y * scale, quaternion.Z * scale, quaternion.W * scale);
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Quaternionn left, Quaternionn right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Quaternionn left, Quaternionn right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        #region public override string ToString()

        /// <summary>
        /// Returns a System.String that represents the current Quaternionn.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("V: {0}, W: {1}", Xyz, W);
        }

        #endregion

        #region public override bool Equals (object o)

        /// <summary>
        /// Compares this object instance to another object for equality. 
        /// </summary>
        /// <param name="other">The other object to be used in the comparison.</param>
        /// <returns>True if both objects are Quaternions of equal value. Otherwise it returns false.</returns>
        public override bool Equals(object other)
        {
            if (other is Quaternionn == false) return false;
            return this == (Quaternionn)other;
        }

        #endregion

        #region public override int GetHashCode ()

        /// <summary>
        /// Provides the hash code for this object. 
        /// </summary>
        /// <returns>A hash code formed from the bitwise XOR of this objects members.</returns>
        public override int GetHashCode()
        {
            return Xyz.GetHashCode() ^ W.GetHashCode();
        }

        #endregion

        #endregion

        #endregion

#if false

        #region Fields

        /// <summary>The W component of the Quaternionn.</summary>
        public nfloat W;

        /// <summary>The X component of the Quaternionn.</summary>
        public nfloat X;

        /// <summary>The Y component of the Quaternionn.</summary>
        public nfloat Y;

        /// <summary>The Z component of the Quaternionn.</summary>
        public nfloat Z;

        #endregion
        
        #region Constructors

        /// <summary>Constructs left Quaternionn that is left copy of the given Quaternionn.</summary>
        /// <param name="quaterniond">The Quaternionn to copy.</param>
        public Quaternionn(ref Quaternionn Quaternionn) : this(Quaternionn.W, Quaternionn.X, Quaternionn.Y, Quaternionn.Z) { }

        /// <summary>Constructs left Quaternionn from the given components.</summary>
        /// <param name="w">The W component for the Quaternionn.</param>
        /// <param name="vector3d">A Vector representing the X, Y, and Z componets for the quaterion.</param>
        public Quaternionn(nfloat w, ref Vector3n vector3d) : this(w, vector3d.X, vector3d.Y, vector3d.Z) { }

        /// <summary>Constructs left Quaternionn from the given axis and angle.</summary>
        /// <param name="axis">The axis for the Quaternionn.</param>
        /// <param name="angle">The angle for the quaternione.</param>
        public Quaternionn(ref Vector3n axis, nfloat angle)
        {
            nfloat halfAngle = Functions.DTOR * angle / 2;

            this.W = System.Math.Cos(halfAngle);

            nfloat sin = System.Math.Sin(halfAngle);
            Vector3n axisNormalized;
            Vector3n.Normalize(ref axis, out axisNormalized);
            this.X = axisNormalized.X * sin;
            this.Y = axisNormalized.Y * sin;
            this.Z = axisNormalized.Z * sin;
        }

        /// <summary>Constructs left Quaternionn from the given components.</summary>
        /// <param name="w">The W component for the Quaternionn.</param>
        /// <param name="x">The X component for the Quaternionn.</param>
        /// <param name="y">The Y component for the Quaternionn.</param>
        /// <param name="z">The Z component for the Quaternionn.</param>
        public Quaternionn(nfloat w, nfloat x, nfloat y, nfloat z)
        {
            this.W = w;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        /// <summary>Constructs left Quaternionn from the given array of nfloat-precision floating-point numbers.</summary>
        /// <param name="nfloatArray">The array of nfloats for the components of the Quaternionn.</param>
        public Quaternionn(nfloat[] nfloatArray)
        {
            if (nfloatArray == null || nfloatArray.GetLength(0) < 4) throw new MissingFieldException();

            this.W = nfloatArray[0];
            this.X = nfloatArray[1];
            this.Y = nfloatArray[2];
            this.Z = nfloatArray[3];
        }

        /// <summary>Constructs left Quaternionn from the given matrix.  Only contains rotation information.</summary>
        /// <param name="matrix">The matrix for the components of the Quaternionn.</param>
        public Quaternionn(ref Matrix4d matrix)
        {
            nfloat scale = System.Math.Pow(matrix.Determinant, 1.0d/3.0d);
 
            W = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] + matrix[1, 1] + matrix[2, 2])) / 2;
            X = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] - matrix[1, 1] - matrix[2, 2])) / 2;
            Y = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] + matrix[1, 1] - matrix[2, 2])) / 2;
            Z = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] - matrix[1, 1] + matrix[2, 2])) / 2; 
            if( matrix[2,1] - matrix[1,2] < 0 ) X = -X;
            if( matrix[0,2] - matrix[2,0] < 0 ) Y = -Y;
            if( matrix[1,0] - matrix[0,1] < 0 ) Z = -Z;
        }

        public Quaternionn(ref Matrix3d matrix)
        {
            nfloat scale = System.Math.Pow(matrix.Determinant, 1.0d / 3.0d);

            W = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] + matrix[1, 1] + matrix[2, 2])) / 2;
            X = System.Math.Sqrt(System.Math.Max(0, scale + matrix[0, 0] - matrix[1, 1] - matrix[2, 2])) / 2;
            Y = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] + matrix[1, 1] - matrix[2, 2])) / 2;
            Z = System.Math.Sqrt(System.Math.Max(0, scale - matrix[0, 0] - matrix[1, 1] + matrix[2, 2])) / 2;
            if (matrix[2, 1] - matrix[1, 2] < 0) X = -X;
            if (matrix[0, 2] - matrix[2, 0] < 0) Y = -Y;
            if (matrix[1, 0] - matrix[0, 1] < 0) Z = -Z;
        }

        #endregion

        #region Arithmetic Operators

        public void Add(ref Quaternionn Quaternionn)
        {
            W = W + Quaternionn.W;
            X = X + Quaternionn.X;
            Y = Y + Quaternionn.Y;
            Z = Z + Quaternionn.Z;
        }
        public void Add(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            result.W = W + Quaternionn.W;
            result.X = X + Quaternionn.X;
            result.Y = Y + Quaternionn.Y;
            result.Z = Z + Quaternionn.Z;
        }
        public static void Add(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result.W = left.W + right.W;
            result.X = left.X + right.X;
            result.Y = left.Y + right.Y;
            result.Z = left.Z + right.Z;
        }

        public void Subtract(ref Quaternionn Quaternionn)
        {
            W = W - Quaternionn.W;
            X = X - Quaternionn.X;
            Y = Y - Quaternionn.Y;
            Z = Z - Quaternionn.Z;
        }
        public void Subtract(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            result.W = W - Quaternionn.W;
            result.X = X - Quaternionn.X;
            result.Y = Y - Quaternionn.Y;
            result.Z = Z - Quaternionn.Z;
        }
        public static void Subtract(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result.W = left.W - right.W;
            result.X = left.X - right.X;
            result.Y = left.Y - right.Y;
            result.Z = left.Z - right.Z;
        }

        public void Multiply(ref Quaternionn Quaternionn)
        {
            nfloat w = W * Quaternionn.W - X * Quaternionn.X - Y * Quaternionn.Y - Z * Quaternionn.Z;
            nfloat x = W * Quaternionn.X + X * Quaternionn.W + Y * Quaternionn.Z - Z * Quaternionn.Y;
            nfloat y = W * Quaternionn.Y + Y * Quaternionn.W + Z * Quaternionn.X - X * Quaternionn.Z;
            Z = W * Quaternionn.Z + Z * Quaternionn.W + X * Quaternionn.Y - Y * Quaternionn.X;
            W = w;
            X = x;
            Y = y;
        }
        public void Multiply(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            result.W = W * Quaternionn.W - X * Quaternionn.X - Y * Quaternionn.Y - Z * Quaternionn.Z;
            result.X = W * Quaternionn.X + X * Quaternionn.W + Y * Quaternionn.Z - Z * Quaternionn.Y;
            result.Y = W * Quaternionn.Y + Y * Quaternionn.W + Z * Quaternionn.X - X * Quaternionn.Z;
            result.Z = W * Quaternionn.Z + Z * Quaternionn.W + X * Quaternionn.Y - Y * Quaternionn.X;
        }
        public static void Multiply(ref Quaternionn left, ref Quaternionn right, out Quaternionn result)
        {
            result.W = left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z;
            result.X = left.W * right.X + left.X * right.W + left.Y * right.Z - left.Z * right.Y;
            result.Y = left.W * right.Y + left.Y * right.W + left.Z * right.X - left.X * right.Z;
            result.Z = left.W * right.Z + left.Z * right.W + left.X * right.Y - left.Y * right.X;
        }

        public void Multiply(nfloat scalar)
        {
            W = W * scalar;
            X = X * scalar;
            Y = Y * scalar;
            Z = Z * scalar;
        }
        public void Multiply(nfloat scalar, out Quaternionn result)
        {
            result.W = W * scalar;
            result.X = X * scalar;
            result.Y = Y * scalar;
            result.Z = Z * scalar;
        }
        public static void Multiply(ref Quaternionn Quaternionn, nfloat scalar, out Quaternionn result)
        {
            result.W = Quaternionn.W * scalar;
            result.X = Quaternionn.X * scalar;
            result.Y = Quaternionn.Y * scalar;
            result.Z = Quaternionn.Z * scalar;
        }

        public void Divide(nfloat scalar)
        {
            if (scalar == 0) throw new DivideByZeroException();
            W = W / scalar;
            X = X / scalar;
            Y = Y / scalar;
            Z = Z / scalar;
        }
        public void Divide(nfloat scalar, out Quaternionn result)
        {
            if (scalar == 0) throw new DivideByZeroException();
            result.W = W / scalar;
            result.X = X / scalar;
            result.Y = Y / scalar;
            result.Z = Z / scalar;
        }
        public static void Divide(ref Quaternionn Quaternionn, nfloat scalar, out Quaternionn result)
        {
            if (scalar == 0) throw new DivideByZeroException();
            result.W = Quaternionn.W / scalar;
            result.X = Quaternionn.X / scalar;
            result.Y = Quaternionn.Y / scalar;
            result.Z = Quaternionn.Z / scalar;
        }

        #endregion
        
        #region Functions

        public nfloat Modulus
        {
            get
            {
                return System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            }
        }
        public nfloat ModulusSquared
        {
            get
            {
                return W * W + X * X + Y * Y + Z * Z;
            }
        }

        public static nfloat DotProduct(Quaternionn left, Quaternionn right)
        {
            return left.W * right.W + left.X * right.X + left.Y * right.Y + left.Z * right.Z;
        }

        public void Normalize()
        {
            nfloat modulus = System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            if (modulus == 0) throw new DivideByZeroException();
            W = W / modulus;
            X = X / modulus;
            Y = Y / modulus;
            Z = Z / modulus;
        }
        public void Normalize( out Quaternionn result )
        {
            nfloat modulus = System.Math.Sqrt(W * W + X * X + Y * Y + Z * Z);
            if (modulus == 0) throw new DivideByZeroException();
            result.W = W / modulus;
            result.X = X / modulus;
            result.Y = Y / modulus;
            result.Z = Z / modulus;
        }
        public static void Normalize(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            nfloat modulus = System.Math.Sqrt(Quaternionn.W * Quaternionn.W + Quaternionn.X * Quaternionn.X + Quaternionn.Y * Quaternionn.Y + Quaternionn.Z * Quaternionn.Z);
            if (modulus == 0) throw new DivideByZeroException();
            result.W = Quaternionn.W / modulus;
            result.X = Quaternionn.X / modulus;
            result.Y = Quaternionn.Y / modulus;
            result.Z = Quaternionn.Z / modulus;
        }

        public void Conjugate()
        {
            X = -X;
            Y = -Y;
            Z = -Z;
        }
        public void Conjugate( out Quaternionn result )
        {
            result.W = W;
            result.X = -X;
            result.Y = -Y;
            result.Z = -Z;
        }
        public static void Conjugate(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            result.W = Quaternionn.W;
            result.X = -Quaternionn.X;
            result.Y = -Quaternionn.Y;
            result.Z = -Quaternionn.Z;
        }

        public void Inverse()
        {
            nfloat modulusSquared = W * W + X * X + Y * Y + Z * Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            nfloat inverseModulusSquared = 1.0 / modulusSquared;
            W = W * inverseModulusSquared;
            X = X * -inverseModulusSquared;
            Y = Y * -inverseModulusSquared;
            Z = Z * -inverseModulusSquared;
        }
        public void Inverse( out Quaternionn result )
        {
            nfloat modulusSquared = W * W + X * X + Y * Y + Z * Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            nfloat inverseModulusSquared = 1.0 / modulusSquared;
            result.W = W * inverseModulusSquared;
            result.X = X * -inverseModulusSquared;
            result.Y = Y * -inverseModulusSquared;
            result.Z = Z * -inverseModulusSquared;
        }
        public static void Inverse(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            nfloat modulusSquared = Quaternionn.W * Quaternionn.W + Quaternionn.X * Quaternionn.X + Quaternionn.Y * Quaternionn.Y + Quaternionn.Z * Quaternionn.Z;
            if (modulusSquared <= 0) throw new InvalidOperationException();
            nfloat inverseModulusSquared = 1.0 / modulusSquared;
            result.W = Quaternionn.W * inverseModulusSquared;
            result.X = Quaternionn.X * -inverseModulusSquared;
            result.Y = Quaternionn.Y * -inverseModulusSquared;
            result.Z = Quaternionn.Z * -inverseModulusSquared;
        }

        public void Log()
        {
            if (System.Math.Abs(W) < 1.0)
            {
                nfloat angle = System.Math.Acos(W);
                nfloat sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    nfloat coefficient = angle / sin;
                    X = X * coefficient;
                    Y = Y * coefficient;
                    Z = Z * coefficient;
                }
            }
            else
            {
                X = 0;
                Y = 0;
                Z = 0;
            }

            W = 0;
        }
        public void Log( out Quaternionn result )
        {
            if (System.Math.Abs(W) < 1.0)
            {
                nfloat angle = System.Math.Acos(W);
                nfloat sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    nfloat coefficient = angle / sin;
                    result.X = X * coefficient;
                    result.Y = Y * coefficient;
                    result.Z = Z * coefficient;
                }
                else
                {
                    result.X = X;
                    result.Y = Y;
                    result.Z = Z;
                }
            }
            else
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }

            result.W = 0;
        }
        public static void Log(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            if (System.Math.Abs(Quaternionn.W) < 1.0)
            {
                nfloat angle = System.Math.Acos(Quaternionn.W);
                nfloat sin = System.Math.Sin(angle);

                if (System.Math.Abs(sin) >= 0)
                {
                    nfloat coefficient = angle / sin;
                    result.X = Quaternionn.X * coefficient;
                    result.Y = Quaternionn.Y * coefficient;
                    result.Z = Quaternionn.Z * coefficient;
                }
                else
                {
                    result.X = Quaternionn.X;
                    result.Y = Quaternionn.Y;
                    result.Z = Quaternionn.Z;
                }
            }
            else
            {
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }

            result.W = 0;
        }

        public void Exp()
        {
            nfloat angle = System.Math.Sqrt(X * X + Y * Y + Z * Z);
            nfloat sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                nfloat coefficient = angle / sin;
                W = 0;
                X = X * coefficient;
                Y = Y * coefficient;
                Z = Z * coefficient;
            }
            else
            {
                W = 0;
            }
        }
        public void Exp(out Quaternionn result)
        {
            nfloat angle = System.Math.Sqrt(X * X + Y * Y + Z * Z);
            nfloat sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                nfloat coefficient = angle / sin;
                result.W = 0;
                result.X = X * coefficient;
                result.Y = Y * coefficient;
                result.Z = Z * coefficient;
            }
            else
            {
                result.W = 0;
                result.X = X;
                result.Y = Y;
                result.Z = Z;
            }
        }
        public static void Exp(ref Quaternionn Quaternionn, out Quaternionn result)
        {
            nfloat angle = System.Math.Sqrt(Quaternionn.X * Quaternionn.X + Quaternionn.Y * Quaternionn.Y + Quaternionn.Z * Quaternionn.Z);
            nfloat sin = System.Math.Sin(angle);

            if (System.Math.Abs(sin) > 0)
            {
                nfloat coefficient = angle / sin;
                result.W = 0;
                result.X = Quaternionn.X * coefficient;
                result.Y = Quaternionn.Y * coefficient;
                result.Z = Quaternionn.Z * coefficient;
            }
            else
            {
                result.W = 0;
                result.X = Quaternionn.X;
                result.Y = Quaternionn.Y;
                result.Z = Quaternionn.Z;
            }
        }

        /// <summary>Returns left matrix for this Quaternionn.</summary>
        public void Matrix4d(out Matrix4d result)
        {
            // TODO Expand
            result = new Matrix4d(ref this);
        }

        public void GetAxisAndAngle(out Vector3n axis, out nfloat angle)
        {
            Quaternionn Quaternionn;
            Normalize(out Quaternionn);
            nfloat cos = Quaternionn.W;
            angle = System.Math.Acos(cos) * 2 * Functions.RTOD;
            nfloat sin = System.Math.Sqrt( 1.0d - cos * cos );
            if ( System.Math.Abs( sin ) < 0.0001 ) sin = 1;
            axis = new Vector3n(X / sin, Y / sin, Z / sin);
        }

        public static void Slerp(ref Quaternionn start, ref Quaternionn end, nfloat blend, out Quaternionn result)
        {
            if (start.W == 0 && start.X == 0 && start.Y == 0 && start.Z == 0)
            {
                if (end.W == 0 && end.X == 0 && end.Y == 0 && end.Z == 0)
                {
                    result.W = 1;
                    result.X = 0;
                    result.Y = 0;
                    result.Z = 0;
                }
                else
                {
                    result = end;
                }
            }
            else if (end.W == 0 && end.X == 0 && end.Y == 0 && end.Z == 0)
            {
                result = start;
            }

            Vector3n startVector = new Vector3n(start.X, start.Y, start.Z);
            Vector3n endVector = new Vector3n(end.X, end.Y, end.Z);
            nfloat cosHalfAngle = start.W * end.W + Vector3n.Dot(startVector, endVector);

            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                // angle = 0.0f, so just return one input.
                result = start;
            }
            else if (cosHalfAngle < 0.0f)
            {
                end.W = -end.W;
                end.X = -end.X;
                end.Y = -end.Y;
                end.Z = -end.Z;
                cosHalfAngle = -cosHalfAngle;
            }

            nfloat blendA;
            nfloat blendB;
            if (cosHalfAngle < 0.99f)
            {
                // do proper slerp for big angles
                nfloat halfAngle = (nfloat)System.Math.Acos(cosHalfAngle);
                nfloat sinHalfAngle = (nfloat)System.Math.Sin(halfAngle);
                nfloat oneOverSinHalfAngle = 1.0f / sinHalfAngle;
                blendA = (nfloat)System.Math.Sin(halfAngle * (1.0f - blend)) * oneOverSinHalfAngle;
                blendB = (nfloat)System.Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
            }
            else
            {
                // do lerp if angle is really small.
                blendA = 1.0f - blend;
                blendB = blend;
            }

            result.W = blendA * start.W + blendB * end.W;
            result.X = blendA * start.X + blendB * end.X;
            result.Y = blendA * start.Y + blendB * end.Y;
            result.Z = blendA * start.Z + blendB * end.Z;

            if (result.W != 0 || result.X != 0 || result.Y != 0 || result.Z != 0)
            {
                result.Normalize();
            }
            else
            {
                result.W = 1;
                result.X = 0;
                result.Y = 0;
                result.Z = 0;
            }
        }

        #endregion
        
        #region HashCode

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode()
        {
            base.GetHashCode();
            return W.GetHashCode() ^ X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        #endregion
        
        #region String and Parse

        /// <summary>Returns the fully qualified type name of this instance.</summary>
        /// <returns>A System.String containing left fully qualified type name.</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", W, X, Y, Z);
        }

        /// <summary>Parses left string, converting it to left Quaternionn.</summary>
        /// <param name="str">The string to parse.</param>
        /// <returns>The Quaternionn represented by the string.</returns>
        public static void Parse(string str, out Quaternionn result)
        {
            Match match = new Regex(@"\((?<w>.*),(?<x>.*),(?<y>.*),(?<z>.*)\)", RegexOptions.None).Match(str);
            if (!match.Success) throw new Exception("Parse failed!");

            result.W = nfloat.Parse(match.Result("${w}"));
            result.X = nfloat.Parse(match.Result("${x}"));
            result.Y = nfloat.Parse(match.Result("${y}"));
            result.Z = nfloat.Parse(match.Result("${z}"));
        }

        #endregion
        
        #region Constants

        /// <summary>A quaterion with all zero components.</summary>
        public static readonly Quaternionn Zero = new Quaternionn(0, 0, 0, 0);

        /// <summary>A quaterion representing an identity.</summary>
        public static readonly Quaternionn Identity = new Quaternionn(1, 0, 0, 0);

        /// <summary>A quaterion representing the W axis.</summary>
        public static readonly Quaternionn WAxis = new Quaternionn(1, 0, 0, 0);

        /// <summary>A quaterion representing the X axis.</summary>
        public static readonly Quaternionn XAxis = new Quaternionn(0, 1, 0, 0);

        /// <summary>A quaterion representing the Y axis.</summary>
        public static readonly Quaternionn YAxis = new Quaternionn(0, 0, 1, 0);

        /// <summary>A quaterion representing the Z axis.</summary>
        public static readonly Quaternionn ZAxis = new Quaternionn(0, 0, 0, 1);

        #endregion

#endif

        #region IEquatable<Quaternionn> Members

        /// <summary>
        /// Compares this Quaternionn instance to another Quaternionn for equality. 
        /// </summary>
        /// <param name="other">The other Quaternionn to be used in the comparison.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public bool Equals(Quaternionn other)
        {
            return Xyz == other.Xyz && W == other.W;
        }

        #endregion
    }
}

#endif // HAVE_NATIVE_TYPES
