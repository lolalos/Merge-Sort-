# Merge Sort: Explicación Matemática

---

## Definición:

**Merge Sort** es un algoritmo de ordenamiento basado en la técnica de **Divide y Vencerás**. La idea principal es dividir el arreglo en dos mitades, ordenarlas recursivamente y luego fusionarlas para obtener el arreglo final ordenado.

---

## Algoritmo:

Dado un arreglo **A** de tamaño **n**:

### 1. División:

Se divide el arreglo en dos sub-arreglos:

- **A (izquierda)** = { A[0], A[1], ..., A[n/2 - 1] }
- **A (derecha)** = { A[n/2], A[n/2 + 1], ..., A[n - 1] }

### 2. Ordenación Recursiva:

Se aplica **Merge Sort** recursivamente en ambos sub-arreglos hasta llegar a arreglos de tamaño 1.

### 3. Fusión:

Se toman dos sub-arreglos ordenados, **A (izquierda)** y **A (derecha)**, y se fusionan para formar un único arreglo ordenado comparando elementos:

**C[k] = min(A (izquierda)[i], A (derecha)[j])**

---

## Análisis de Complejidad:

### Complejidad Temporal:

1. **División:** En cada nivel de recursión, el arreglo se divide en dos mitades. Existen log₂(n) niveles en total.

2. **Fusión:** Fusionar dos sub-arreglos toma O(n) operaciones.

La relación de recurrencia es:

**T(n) = 2T(n/2) + O(n)**

Esto se resuelve como:

**T(n) = O(n log n)**

### Complejidad Espacial:

**Merge Sort** requiere espacio adicional para los arreglos temporales que se utilizan durante la fusión, lo que da una complejidad espacial de **O(n)**.

---

## Ejemplo:

### Arreglo original:

A = {38, 27, 43, 3, 9, 82}

### Paso 1: División:

1. {38, 27, 43, 3, 9, 82} → {38, 27, 43}, {3, 9, 82}
2. {38, 27, 43} → {38}, {27, 43}
3. {3, 9, 82} → {3}, {9, 82}

### Paso 2: Fusión:

1. {27, 43} → {27, 43}
2. {9, 82} → {9, 82}
3. {38}, {27, 43} → {27, 38, 43}
4. {3}, {9, 82} → {3, 9, 82}

### Paso 3: Fusión final:

{27, 38, 43}, {3, 9, 82} → {3, 9, 27, 38, 43, 82}

---

## Conclusión:

- **Complejidad Temporal:** **O(n log n)**
- **Complejidad Espacial:** **O(n)**
- **Algoritmo estable:** Mantiene el orden relativo de los elementos iguales.

**Merge Sort** es un algoritmo eficiente y estable, ideal para ordenar grandes volúmenes de datos con una complejidad temporal de **O(n log n)**.



