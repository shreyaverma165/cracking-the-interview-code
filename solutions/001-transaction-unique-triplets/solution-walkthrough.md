# Visualizing the Three Sum Algorithm

### Initialize pointers:
- `i = 0` (first element)
- `left = i + 1` (second element)
- `right = last element`

### Iteration 1:
- `transactions[i] = 10`
- `left = 20`
- `right = 90`

**Diagram:**
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^   ^                            ^
 i  left                        right
```
#### Calculate sum: 10 + 20 + 90 = 120 (greater than target)
#### Move right left: right = 80

```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^   ^                        ^
 i  left                    right
```
#### Calculate sum: 10 + 20 + 80 = 110 (greater than target)
#### Move right left: right = 70

```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^   ^                   ^
 i  left               right
```
#### Calculate sum: 10 + 20 + 70 = 100 (equal to target)
#### Found triplet [10, 20, 70]

```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^   ^                   ^
 i  left               right
```
#### Triplet found: [10, 20, 70]
#### Move left right and right left

### Iteration 2:
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^        ^                   ^
 i       left               right
```
#### Calculate sum: 10 + 30 + 60 = 100 (equal to target)
#### Found triplet [10, 30, 60]
```
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^        ^                   ^
 i       left               right
```
#### Triplet found: [10, 30, 60]
#### Move left right and right left

### Iteration 3:
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^             ^             ^
 i            left         right
```
#### Calculate sum: 10 + 40 + 50 = 100 (equal to target)
#### Found triplet [10, 40, 50]
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
 ^             ^             ^
 i            left         right
```
#### Triplet found: [10, 40, 50]
#### Move left right and right left

### Iteration 4:

#### Increment i
#### i = 1, left = i + 1, right = last element
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^                        ^
     i  left                    right
```
#### Calculate sum: 20 + 30 + 90 = 140 (greater than target)
#### Move right left: right = 80
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^                    ^
     i  left                right
```
#### Calculate sum: 20 + 30 + 80 = 130 (greater than target)
#### Move right left: right = 70
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^               ^
     i  left           right
```
#### Calculate sum: 20 + 30 + 70 = 120 (greater than target)
#### Move right left: right = 60
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^          ^
     i  left      right
```
#### Calculate sum: 20 + 30 + 60 = 110 (greater than target)
#### Move right left: right = 50
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^       ^
     i  left   right
```
#### Calculate sum: 20 + 30 + 50 = 100 (equal to target)
#### Found triplet [20, 30, 50]
```plaintext
[10, 20, 30, 40, 50, 60, 70, 80, 90]
     ^   ^       ^
     i  left   right
```
#### Triplet found: [20, 30, 50]
#### And so on, incrementing i and adjusting left and right pointers until all possible triplets are found.
