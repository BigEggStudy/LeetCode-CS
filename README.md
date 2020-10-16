[![AppVeyor Build Status](https://img.shields.io/appveyor/build/bigegg/leetcode-cs?label=Windows%20Build%20Status&logo=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/BigEgg/leetcode-cs)
[![Solved Problems](https://img.shields.io/badge/Solved%20Problems-825-blue.svg?style=flat-square)](https://github.com/BigEggStudy/LeetCode-CS)

# LeetCode
The C# solutions for LeetCode problems.

## Problems

### Table of Contents
* [001-050](#Problems-001-050)
* [051-100](#Problems-051-100)
* [101-150](#Problems-101-150)
* [151-200](#Problems-151-200)
* [201-250](#Problems-201-250)
* [251-300](#Problems-251-300)
* [301-350](#Problems-301-350)
* [351-400](#Problems-351-400)
* [401-450](#Problems-401-450)
* [451-500](#Problems-451-500)
* [501-550](#Problems-501-550)
* [551-600](#Problems-551-600)
* [601-650](#Problems-601-650)
* [651-700](#Problems-651-700)
* [701-750](#Problems-701-750)
* [751-800](#Problems-751-800)
* [801-850](#Problems-801-850)
* [851-900](#Problems-851-900)
* [901-950](#Problems-901-950)
* [951-1000](#Problems-951-1000)
* [1001-1050](#Problems-1001-1050)
* [1051-1100](#Problems-1051-1100)
* [1101-1150](#Problems-1101-1150)
* [1151-1200](#Problems-1151-1200)
* [1201-1250](#Problems-1201-1250)
* [1251-1300](#Problems-1251-1300)
* [1301-1350](#Problems-1301-1350)
* [1351-1400](#Problems-1351-1400)
* [1401-1450](#Problems-1401-1450)
* [1451-1500](#Problems-1451-1500)
* [1501-1550](#Problems-1501-1550)

### Problems 001-050
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1 | Two Sum | [C#](./LeetCode/0001-0050/001-TwoSum.cs)(232ms) | O(N) | O(N) | |
| 2 | Add Two Numbers | [C#](./LeetCode/0001-0050/002-AddTwoNumbers.cs)(112ms) | O(Max(N, M)) | O(1) | |
| 3 | Longest Substring Without Repeating Characters | [C#](./LeetCode/0001-0050/003-LongestSubstringWithoutRepeatingCharacters.cs)(80ms) | O(N) | O(1) | C# use array will slower |
| 4 | Median of Two Sorted Arrays | [C#](./LeetCode/0001-0050/004-MedianOfTwoSortedArrays.cs)(112ms) | O(Log(N+M)) | O(1) | |
| 5 | Longest Palindromic Substring | [C#](./LeetCode/0001-0050/005-LongestPalindromicSubstring.cs)(80ms) | O(N) | O(N) | Use Manacher's Algorithm |
| 6 | ZigZag Conversion | [C#](./LeetCode/0001-0050/006-ZigZagConversion.cs)(148ms) | O(N) | O(N) | |
| 7 | Reverse Integer | [C#](./LeetCode/0001-0050/007-ReverseInteger.cs)(40ms) | O(1) | O(1) | |
| 8 | String to Integer (atoi) | [C#](./LeetCode/0001-0050/008-StringToInteger(atoi).cs)(144ms) | O(1) | O(1) | |
| 9 | Palindrome Number | [C#](./LeetCode/0001-0050/009-PalindromeNumber.cs)(64ms) | O(1) | O(1) | |
| 10 | Regular Expression Matching | [C#](./LeetCode/0001-0050/010-RegularExpressionMatching.cs)(68ms) | O(N*M) | O(N*M) | |
| 11 | Container With Most Water | [C#](./LeetCode/0001-0050/011-ContainerWithMostWater.cs)(104ms) | O(N) | O(1) | |
| 12 | Integer to Roman | [C#](./LeetCode/0001-0050/012-IntegerToRoman.cs)(96ms) | O(N) | O(1) | |
| 13 | Roman to Integer | [C#](./LeetCode/0001-0050/013-RomanToInteger.cs)(84ms) | O(N) | O(1) | |
| 14 | Longest Common Prefix | [C#](./LeetCode/0001-0050/014-LongestCommonPrefix.cs)(96ms) | O(N) | O(1) | |
| 15 | 3Sum | [C#](./LeetCode/0001-0050/015-3Sum.cs)(300ms) | O(N<sup>2</sup>) | O(M) | For Python solution, use count to reduce time to O(min(N, M<sup>2</sup>)) and space to O(M) |
| 16 | 3Sum Closest | [C#](./LeetCode/0001-0050/016-3SumClosest.cs)(164ms) | O(N<sup>2</sup>) | O(1) | |
| 17 | Letter Combinations of a Phone Number | [C#](./LeetCode/0001-0050/017-LetterCombinationsOfAPhoneNumber.cs)(232ms) | O(4<sup>N</sup>) | O(4<sup>N</sup>) | |
| 18 | 4Sum | [C#](./LeetCode/0001-0050/018-4Sum.cs)(532ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 19 | Remove Nth Node From End of List | [C#](./LeetCode/0001-0050/019-RemoveNthNodeFromEndOfList.cs)(152ms) | O(N) | O(1) | |
| 20 | Valid Parentheses | [C#](./LeetCode/0001-0050/020-ValidParentheses.cs)(68ms) | O(N) | O(N) | |
| 21 | Merge Two Sorted Lists | [C#](./LeetCode/0001-0050/021-MergeTwoSortedLists.cs)(88ms) | O(N<sub>1</sub>+N<sub>2</sub>) | O(1) | |
| 22 | Generate Parentheses | [C#](./LeetCode/0001-0050/022-GenerateParentheses.cs)(232ms) | O(N) | O(?) | |
| 23 | Merge k Sorted Lists | [C#](./LeetCode/0001-0050/023-MergeKSortedLists.cs)(104ms) | O(N*logk) | O(1) | Python solution use heap to compare the lists, so reduce time to O(N logK) but increase space to O(k) |
| 24 | Swap Nodes in Pairs | [C#](./LeetCode/0001-0050/024-SwapNodesInPairs.cs)(148ms) | O(N) | O(1) | |
| 25 | Reverse Nodes in k-Group | [C#](./LeetCode/0001-0050/025-ReverseNodesInKGroup.cs)(160ms) | O(N) | O(1) | |
| 26 | Remove Duplicates from Sorted Array | [C#](./LeetCode/0001-0050/026-RemoveDuplicatesFromSortedArray.cs)(248ms) | O(N) | O(1) | |
| 27 | Remove Element | [C#](./LeetCode/0001-0050/027-RemoveElement.cs)(236ms) | O(N) | O(1) | |
| 28 | Implement strStr() | [C#](./LeetCode/0001-0050/028-ImplementStrStr.cs)(80ms) | O(N+M) | O(1) | Use Knuth–Morris–Pratt Algorithm |
| 29 | Divide Two Integers | [C#](./LeetCode/0001-0050/029-DivideTwoIntegers.cs)(60ms) | O(N) | O(1) | |
| 30 | Substring with Concatenation of All Words | [C#](./LeetCode/0001-0050/030-SubstringWithConcatenationOfAllWords.cs)(828ms) | O(N*M) | O(M) | |
| 31 | Next Permutation | [C#](./LeetCode/0001-0050/031-NextPermutation.cs)(232ms) | O(N) | O(1) | |
| 32 | Longest Valid Parentheses | [C#](./LeetCode/0001-0050/032-LongestValidParentheses.cs)(124ms) | O(N) | O(1) | |
| 33 | Search in Rotated Sorted Array | [C#](./LeetCode/0001-0050/033-SearchInRotatedSortedArray.cs)(84ms) | O(N) | O(1) | |
| 34 | Search for a Range | [C#](./LeetCode/0001-0050/034-SearchForARange.cs)(240ms) | O(LogN) | O(1) | |
| 35 | Search Insert Position | [C#](./LeetCode/0001-0050/035-SearchInsertPosition.cs)(92ms) | O(LogN) | O(1) | |
| 36 | Valid Sudoku | [C#](./LeetCode/0001-0050/036-ValidSudoku.cs)(160ms) | O(1) | O(1) | |
| 37 | Sudoku Solver | [C#](./LeetCode/0001-0050/037-SudokuSolver.cs)(168ms) | O(1) | N(1) | |
| 38 | Count and Say | [C#](./LeetCode/0001-0050/038-CountAndSay.cs)(80ms) | O(N<sup>2</sup>) | O(N) | Python use an dictionary of answers |
| 39 | Combination Sum | [C#](./LeetCode/0001-0050/039-CombinationSum.cs)(236ms) | O(N!) | O(N) | |
| 40 | Combination Sum II | [C#](./LeetCode/0001-0050/040-CombinationSum2.cs)(484ms) | O(N!) | O(N) | |
| 41 | First Missing Positive | [C#](./LeetCode/0001-0050/041-FirstMissingPositive.cs)(84ms) | O(N) | O(1) | |
| 42 | Trapping Rain Water | [C#](./LeetCode/0001-0050/042-TrappingRainWater.cs)(88ms) | O(N) | O(1) | |
| 43 | Multiply Strings | [C#](./LeetCode/0001-0050/043-MultiplyStrings.cs)(140ms) | O(N*M) | O(N+M) | |
| 44 | Wildcard Matching | [C#](./LeetCode/0001-0050/044-WildcardMatching.cs)(160ms) | O(N*M) | O(1) | Similar with [Problem No. 10](./Problems/0001-0050/010-RegularExpressionMatching.md) |
| 45 | Jump Game II | [C#](./LeetCode/0001-0050/045-JumpGame2.cs)(88ms) | O(N) | O(1) | Use Greedy Algorithm |
| 46 | Permutations | [C#](./LeetCode/0001-0050/046-Permutations.cs)(492ms) | O(N!) | (N) | Get inspired by [Heap's Algorithm](https://en.wikipedia.org/wiki/Heap%27s_algorithm) |
| 47 | Permutations II | [C#](./LeetCode/0001-0050/047-Permutations2.cs)(492ms) | O(N!) | (N) | Get inspired by [Heap's Algorithm](https://en.wikipedia.org/wiki/Heap%27s_algorithm) |
| 48 | Rotate Image | [C#](./LeetCode/0001-0050/048-RotateImage.cs)(148ms) | O(N<sup>2</sup>) | O(1) | |
| 49 | Group Anagrams | [C#](./LeetCode/0001-0050/049-GroupAnagrams.cs)(288ms) | O(N K log K) | O(N K) | Linear algorithm will slower and cost more memory |
| 50 | Pow(x, n) | [C#](./LeetCode/0001-0050/050-Pow.cs)(48ms) | O(LogN) | O(1) | |

### Problems 051-100
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 51 | N-Queens | [C#](./LeetCode/0051-0100/051-NQueens.cs)(396ms) | O(N!) | O(N) | |
| 52 | N-Queens II | [C#](./LeetCode/0051-0100/052-NQueens2.cs)(52ms) | O(N!) | O(N) | |
| 53 | Maximum Subarray | [C#](./LeetCode/0051-0100/053-MaximumSubarray.cs)(88ms) | O(N) | O(1) | |
| 54 | Spiral Matrix | [C#](./LeetCode/0051-0100/054-SpiralMatrix.cs)(476ms) | O(N) | O(1) | |
| 55 | Jump Game | [C#](./LeetCode/0051-0100/055-JumpGame.cs)(96ms) | O(N) | O(1) | Use Greedy Algorithm |
| 56 | Merge Intervals | [C#](./LeetCode/0051-0100/056-MergeIntervals.cs)(256ms) | O(NLogN) | O(1) | |
| 57 | Insert Interval | [C#](./LeetCode/0051-0100/057-InsertInterval.cs)(252ms) | O(N) | O(N) | |
| 58 | Length of Last Word | [C#](./LeetCode/0051-0100/058-LengthOfLastWord.cs)(72msms) | O(N) | O(1) | |
| 59 | Spiral Matrix II | [C#](./LeetCode/0051-0100/059-SpiralMatrix2.cs)(48ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 60 | Permutation Sequence | [C#](./LeetCode/0051-0100/060-PermutationSequence.cs)(80ms) | O(N) | (N) | Use Cantor Expansion (Introduction to Algorithms, MIT) |
| 61 | Rotate List | [C#](./LeetCode/0051-0100/061-RotateList.cs)(84ms) | O(N) | O(1) | |
| 62 | Unique Paths | [C#](./LeetCode/0051-0100/062-UniquePaths.cs)(40ms) | O(Min(M, N)) | O(1) | Use dynamic programing will cost O(M*N) time and O(Min(M, N)) space |
| 63 | Unique Paths II | [C#](./LeetCode/0051-0100/063-UniquePaths2.cs)(160ms) | O(M*N) | O(Min(M, N)) | |
| 64 | Minimum Path Sum | [C#](./LeetCode/0051-0100/064-MinimumPathSum.cs)(104ms) | O(M*N) | O(Min(M, N)) | Update grid to not use new space |
| 65 | Valid Number | [C#](./LeetCode/0051-0100/065-ValidNumber.cs)(144ms) | O(N) | O(1) | |
| 66 | Plus One | [C#](./LeetCode/0051-0100/066-PlusOne.cs)(228ms) | O(N) | O(N) | |
| 67 | Add Binary | [C#](./LeetCode/0051-0100/067-AddBinary.cs)(80ms) | O(N) | O(N) | |
| 68 | Text Justification | [C#](./LeetCode/0051-0100/068-TextJustification.cs)(244ms) | O(N) | O(N) | |
| 69 | Sqrt(x) | [C#](./LeetCode/0051-0100/069-Sqrt(x).cs)(44ms) | O(LogN) | O(1) | Use [Newton–Raphson Method](https://en.wikipedia.org/wiki/Newton%27s_method) to [computing square root](https://en.wikipedia.org/wiki/Methods_of_computing_square_roots) |
| 70 | Climbing Stairs | [C#](./LeetCode/0051-0100/070-ClimbingStairs.cs)(40ms) | O(N) | O(1) | |
| 71 | Simplify Path | [C#](./LeetCode/0051-0100/071-SimplifyPath.cs)(132ms) | O(N) | O(N) | |
| 72 | Edit Distance | [C#](./LeetCode/0051-0100/072-EditDistance.cs)(76ms) | O(N*M) | O(Min(N,M)) | |
| 73 | Set Matrix Zeroes | [C#](./LeetCode/0051-0100/073-SetMatrixZeroes.cs)(184ms) | O(N*M) | O(N+M) | When use constant space, solution will slower |
| 74 | Search a 2D Matrix | [C#](./LeetCode/0051-0100/074-SearchA2DMatrix.cs)(92ms) | O(Log(N+M)) | O(1) | |
| 75 | Sort Colors | [C#](./LeetCode/0051-0100/075-SortColors.cs)(236ms) | O(N) | O(1) | |
| 76 | Minimum Window Substring | [C#](./LeetCode/0051-0100/076-MinimumWindowSubstring.cs)(84ms) | O(N+M) | O(1) | |
| 77 | Combinations | [C#](./LeetCode/0051-0100/077-Combinations.cs)(416ms) | O((N-K)!) | O(N!/K!) | |
| 78 | Subsets | [C#](./LeetCode/0051-0100/078-Subsets.cs)(232ms) | O(N*2<sup>n</sup>) | O(1) | |
| 79 | Word Search | [C#](./LeetCode/0051-0100/079-WordSearch.cs)(148ms) | O(N*M) | O(N*M) | |
| 80 | Remove Duplicates from Sorted Array II | [C#](./LeetCode/0051-0100/080-RemoveDuplicatesFromSortedArray2.cs)(480ms) | O(N) | O(1) | |
| 81 | Search in Rotated Sorted Array II | [C#](./LeetCode/0051-0100/081-SearchInRotatedSortedArray2.cs)(156ms) | O(N) | O(1) | |
| 82 | Remove Duplicates from Sorted List II | [C#](./LeetCode/0051-0100/082-RemoveDuplicatesFromSortedList2.cs)(168ms) | O(N) | O(1) | |
| 83 | Remove Duplicates from Sorted List | [C#](./LeetCode/0051-0100/083-RemoveDuplicatesFromSortedList.cs)(92ms) | O(N) | O(1) | |
| 84 | Largest Rectangle in Histogram | [C#](./LeetCode/0051-0100/084-LargestRectangleInHistogram.cs)(96ms) | O(N) | O(N) | |
| 85 | Maximal Rectangle | [C#](./LeetCode/0051-0100/085-MaximalRectangle.cs)(120ms) | O(N*M) | O(M) | |
| 86 | Partition List | [C#](./LeetCode/0051-0100/086-PartitionList.cs)(148ms) | O(N) | N(1) | |
| 87 | Scramble String | [C#](./LeetCode/0051-0100/087-ScrambleString.cs)(104ms) | O(NLogN) | O(1) | |
| 88 | Merge Sorted Array | [C#](./LeetCode/0051-0100/088-MergeSortedArray.cs)(236ms) | O(M+N) | O(1) | |
| 89 | Gray Code | [C#](./LeetCode/0051-0100/089-GrayCode.cs)(288ms) | O(2<sup>n</sup>) | O(2<sup>n</sup>) | |
| 90 | Subsets II | [C#](./LeetCode/0051-0100/090-Subsets2.cs)(296ms) | O(2<sup>n</sup>) | O(2<sup>n</sup>) | |
| 91 | Decode Ways | [C#](./LeetCode/0051-0100/091-DecodeWays.cs)(76ms) | O(N) | O(N) | |
| 92 | Reverse Linked List II | [C#](./LeetCode/0051-0100/092-ReverseLinkedList2.cs)(104ms) | O(N) | O(1) | |
| 93 | Restore IP Addresses | [C#](./LeetCode/0051-0100/093-RestoreIPAddresses.cs)(292ms) | O(1) | O(1) | |
| 94 | Binary Tree Inorder Traversal | [C#](./LeetCode/0051-0100/094-BinaryTreeInorderTraversal.cs)(280ms) | O(N) | O(N) | |
| 95 | Unique Binary Search Trees II | [C#](./LeetCode/0051-0100/095-UniqueBinarySearchTree2.cs)(208ms) | O(N) | O(N) | |
| 96 | Unique Binary Search Trees | [C#](./LeetCode/0051-0100/096-UniqueBinarySearchTree.cs)(36ms) | O(N) | O(1) | [Catalan number](https://en.wikipedia.org/wiki/Catalan_number) |
| 97 | Interleaving String | [C#](./LeetCode/0051-0100/097-InterleavingString.cs)(84ms) | O(N*M) | O(N*M) | Dynamic Programing |
| 98 | Validate Binary Search Tree | [C#](./LeetCode/0051-0100/098-ValidateBinarySearchTree.cs)(96ms) | O(N) | O(1) | |
| 99 | Recover Binary Search Tree | [C#](./LeetCode/0051-0100/099-RecoverBinarySearchTree.cs)(140ms) | O(N) | O(N) | [Morris Traversal](https://en.wikipedia.org/wiki/Tree_traversal#Morris_in-order_traversal_using_threading) |
| 100 | Same Tree | [C#](./LeetCode/0051-0100/100-SameTree.cs)(84ms) | O(N) | O(N) | |

### Problems 101-150
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 101 | Symmetric Tree | [C#](./LeetCode/0101-0150/101-SymmetricTree.cs)(96ms) | O(N) | O(N) | |
| 102 | Binary Tree Level Order Traversal | [C#](./LeetCode/0101-0150/102-BinaryTreeLevelOrderTraversal.cs)(240ms) | O(N) | O(N) | |
| 103 | Binary Tree Zigzag Level Order Traversal | [C#](./LeetCode/0101-0150/103-BinaryTreeZigzagLevelOrderTraversal.cs)(244ms) | O(N) | O(N) | |
| 104 | Maximum Depth of Binary Tree | [C#](./LeetCode/0101-0150/104-MaximumDepthOfBinaryTree.cs)(88ms) | O(N) | O(1) | |
| 105 | Construct Binary Tree from Preorder and Inorder Traversal | [C#](./LeetCode/0101-0150/105-ConstructBinaryTreeFromPreorderAndInorderTraversal.cs)(100ms) | O(N) | O(N) | |
| 106 | Construct Binary Tree from Inorder and Postorder Traversal | [C#](./LeetCode/0101-0150/106-ConstructBinaryTreeFromInorderAndPostorderTraversal.cs)(96ms) | O(N) | O(N) | |
| 107 | Binary Tree Level Order Traversal II | [C#](./LeetCode/0101-0150/107-BinaryTreeLevelOrderTraversal2.cs)(236ms) | O(N) | O(N) | |
| 108 | Convert Sorted Array to Binary Search Tree | [C#](./LeetCode/0101-0150/108-ConvertSortedArrayToBinarySearchTree.cs)(88ms) | O(N) | O(N) | |
| 109 | Convert Sorted List to Binary Search Tree | [C#](./LeetCode/0101-0150/109-ConvertSortedListToBinarySearchTree.cs)(116ms) | O(N) | O(LogN) | |
| 110 | Balanced Binary Tree | [C#](./LeetCode/0101-0150/110-BalancedBinaryTree.cs)(96ms) | O(N) | O(1) | |
| 111 | Minimum Depth of Binary Tree | [C#](./LeetCode/0101-0150/111-MinimumDepthOfBinaryTree.cs)(96ms) | O(N) | O(N) | |
| 112 | Path Sum | [C#](./LeetCode/0101-0150/112-PathSum.cs)(96ms) | O(N) | O(N) | |
| 113 | Path Sum II | [C#](./LeetCode/0101-0150/113-PathSum2.cs)(292ms) | O(N) | O(N) | |
| 114 | Flatten Binary Tree to Linked List | [C#](./LeetCode/0101-0150/114-FlattenBinaryTreeToLinkedList.cs)(112ms) | O(N) | O(1) | |
| 115 | Distinct Subsequences | [C#](./LeetCode/0101-0150/115-DistinctSubsequences.cs)(88ms) | O(MN) | O(MN) | Dynamic Programming |
| 116 | Populating Next Right Pointers in Each Node | [C#](./LeetCode/0101-0150/0116-PopulatingNextRightPointersInEachNode.cs)(164ms) | O(N) | O(N) | |
| 117 | Populating Next Right Pointers in Each Node II | [C#](./LeetCode/0101-0150/0117-PopulatingNextRightPointersInEachNode2.cs)(244ms) | O(N) | O(N) | |
| 118 | Pascal's Triangle | [C#](./LeetCode/0101-0150/118-PascalsTriangle.cs)(200ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 119 | Pascal's Triangle II | [C#](./LeetCode/0101-0150/119-PascalsTriangle2.cs)(196ms) | O(N<sup>2</sup>) | O(N) | |
| 120 | Pascal's Triangle | [C#](./LeetCode/0101-0150/120-Triangle.cs)(112ms) | O(N<sup>2</sup>) | O(1) | |
| 121 | Best Time to Buy and Sell Stock | [C#](./LeetCode/0101-0150/0121-BestTimeToBuyAndSellStock.cs)(92ms) | O(N) | O(1) | |
| 122 | Best Time to Buy and Sell Stock II | [C#](./LeetCode/0101-0150/0122-BestTimeToBuyAndSellStock2.cs)(92ms) | O(N) | O(1) | |
| 123 | Best Time to Buy and Sell Stock III | [C#](./LeetCode/0101-0150/0123-BestTimeToBuyAndSellStock3.cs)(92ms) | O(N) | O(1) | |
| 124 | Binary Tree Maximum Path Sum | [C#](./LeetCode/0101-0150/0124-BinaryTreeMaximumPathSum.cs)(104ms) | O(N) | O(N) | |
| 125 | Valid Palindrome | [C#](./LeetCode/0101-0150/0125-ValidPalindrome.cs)(76ms) | O(N) | O(1) | |
| 126 | Word Ladder II | [C#](./LeetCode/0101-0150/0126-WordLadderII.cs)(332ms) | O(N*M) | O(N*M) | Bidirectional BFS |
| 127 | Word Ladder | [C#](./LeetCode/0101-0150/0127-WordLadder.cs)(136ms) | O(N*M) | O(N*M) | Bidirectional BFS |
| 128 | Longest Consecutive Sequence | [C#](./LeetCode/0101-0150/0128-LongestConsecutiveSequence.cs)(96ms) | O(N) | O(N) | |
| 129 | Sum Root to Leaf Numbers | [C#](./LeetCode/0101-0150/0129-SumRootToLeafNumbers.cs)(88ms) | O(N) | O(N) | |
| 130 | Surrounded Regions | [C#](./LeetCode/0101-0150/0130-SurroundedRegions.cs)(332ms) | O(N) | O(N) | Union Find |
| 131 | Palindrome Partitioning | [C#](./LeetCode/0101-0150/0131-PalindromePartitioning.cs)(260ms) | | | |
| 133 | Clone Graph | [C#](./LeetCode/0101-0150/0133-CloneGraph.cs)(248ms) | O(N) | O(N) | |
| 134 | Gas Station | [C#](./LeetCode/0101-0150/0134-GasStation.cs)(88ms) | O(N) | O(1) | |
| 136 | Single Number | [C#](./LeetCode/0101-0150/0136-SingleNumber.cs)(96ms) | O(N) | O(1) | |
| 137 | Single Number II | [C#](./LeetCode/0101-0150/0137-SingleNumberII.cs)(96ms) | O(N) | O(1) | |
| 138 | Copy List with Random Pointer | [C#](./LeetCode/0101-0150/0138-CopyListWithRandomPointer.cs)(92ms) | O(N) | O(N) | |
| 139 | Word Break | [C#](./LeetCode/0101-0150/0139-WordBreak.cs)(92ms) | O(N<sup>2</sup>) | O(N) | |
| 140 | Word Break II | [C#](./LeetCode/0101-0150/0140-WordBreakII.cs)(256ms) | O(2<sup>N</sup>) | O(2<sup>N</sup>) | |
| 141 | Linked List Cycle | [C#](./LeetCode/0101-0150/0141-LinkedListCycle.cs)(96ms) | O(N) | O(1) | |
| 143 | Reorder List | [C#](./LeetCode/0101-0150/0143-ReorderList.cs)(108ms) | O(N) | O(1) | |
| 146 | LRU Cache | [C#](./LeetCode/0101-0150/0146-LRUCache.cs)(244ms) | O(1) | O(N) | |
| 148 | Sort List | [C#](./LeetCode/0101-0150/0148-SortList.cs)(108ms) | O(NlogN) | O(1) | |

### Problems 151-200
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 151 | Reverse Words in a String | [C#](./LeetCode/0151-0200/0151-ReverseWordsInAString.cs)(88ms) | O(N) | O(N) | |
| 152 | Maximum Product Subarray | [C#](./LeetCode/0151-0200/0152-MaximumProductSubarray.cs)(88ms) | O(N) | O(1) | |
| 153 | Find Minimum in Rotated Sorted Array | [C#](./LeetCode/0151-0200/0153-FindMinimumInRotatedSortedArray.cs)(88ms) | O(LogN) | O(1) | |
| 154 | Find Minimum in Rotated Sorted Array II | [C#](./LeetCode/0151-0200/0154-FindMinimumInRotatedSortedArrayII.cs)(84ms) | O(logN) | O(1) | |
| 155 | Min Stack | [C#](./LeetCode/0151-0200/0155-MinStack.cs)(132ms) | O(1) | O(N) | |
| 157 | Read N Characters Given Read4 | [C#](./LeetCode/0151-0200/0157-ReadNCharactersGivenRead4.cs)(80ms) | | | |
| 158 | Read N Characters Given Read4 II - Call multiple times | [C#](./LeetCode/0151-0200/0158-ReadNCharactersGivenRead4II.cs)(264ms) | O(N) | O(1) | |
| 159 | Longest Substring with At Most Two Distinct Characters | [C#](./LeetCode/0151-0200/0159-LongestSubstringWithAtMostTwoDistinctCharacters.cs)(72ms) | O(N) | O(1) | |
| 160 | Intersection of Two Linked Lists | [C#](./LeetCode/0151-0200/0160-IntersectionOfTwoLinkedLists.cs)(116ms) | O(N+M) | O(1) | |
| 162 | Find Peak Element | [C#](./LeetCode/0151-0200/0162-FindPeakElement.cs)(92ms) | O(LogN) | O(1) | |
| 165 | Compare Version Numbers | [C#](./LeetCode/0151-0200/0165-CompareVersionNumbers.cs)(72ms) | O(N+M) | O(N+M) | |
| 166 | Fraction to Recurring Decimal | [C#](./LeetCode/0151-0200/0166-FractionToRecurringDecimal.cs)(76ms) | O(N) | O(N) | |
| 167 | Two Sum II - Input array is sorted | [C#](./LeetCode/0151-0200/0167-TwoSumII.cs)(244ms) | O(N) | O(1) | |
| 168 | Excel Sheet Column Title | [C#](./LeetCode/0151-0200/0168-ExcelSheetColumnTitle.cs)(68ms) | O(logN) | O(1) | |
| 169 | Majority Element | [C#](./LeetCode/0151-0200/0169-MajorityElement.cs)(104ms) | O(N) | O(1) | |
| 170 | Two Sum III - Data structure design | [C#](./LeetCode/0151-0200/0170-TwoSumIIIDataStructureDesign.cs)(216ms) | O(N) | O(N) | |
| 171 | Excel Sheet Column Number | [C#](./LeetCode/0151-0200/0171-ExcelSheetColumnNumber.cs)(72ms) | O(N) | O(1) | |
| 172 | Factorial Trailing Zeroes | [C#](./LeetCode/0151-0200/0172-FactorialTrailingZeroes.cs)(40ms) | O(logN) | O(1) | |
| 173 | Binary Search Tree Iterator | [C#](./LeetCode/0151-0200/0173-BinarySearchTreeIterator.cs)(156ms) | O(N) | O(h) | |
| 174 | Dungeon Game | [C#](./LeetCode/0151-0200/0174-DungeonGame.cs)(92ms) | O(N*M) | O(N*M) | |
| 179 | Largest Number | [C#](./LeetCode/0151-0200/0179-LargestNumber.cs)(124ms) | O(NlogN) | O(N) | |
| 189 | Rotate Array | [C#](./LeetCode/0151-0200/0189-RotateArray.cs)(232ms) | O(N) | O(1) | |
| 190 | Reverse Bits | [C#](./LeetCode/0151-0200/0190-ReverseBits.cs)(44ms) | O(1) | O(1) | |
| 191 | Number of 1 Bits | [C#](./LeetCode/0151-0200/0191-NumberOf1Bits.cs)(36ms) | O(1) | O(1) | |
| 198 | House Robber | [C#](./LeetCode/0151-0200/0198-HouseRobber.cs)(88ms) | O(N) | O(1) | |
| 199 | Binary Tree Right Side View | [C#](./LeetCode/0151-0200/0199-BinaryTreeRightSideView.cs)(232ms) | O(N) | O(h) | |
| 200 | Number of Islands | [C#](./LeetCode/0151-0200/0200-NumberOfIslands.cs)(104ms) | O(N*M) | O(N*M) | |

### Problems 201-250
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 201 | Bitwise AND of Numbers Range | [C#](./LeetCode/0201-0250/0201-BitwiseANDOfNumbersRange.cs)(48ms) | O(logN) | O(1) | Brian Kernighan's Algorithm |
| 202 | Happy Number | [C#](./LeetCode/0201-0250/0202-HappyNumber.cs)(40ms) | O(N) | O(N) | |
| 203 | Remove Linked List Elements | [C#](./LeetCode/0201-0250/0203-RemoveLinkedListElements.cs)(92ms) | O(N) | O(1) | |
| 204 | Count Primes | [C#](./LeetCode/0201-0250/0204-CountPrimes.cs)(60ms) | O(N) | O(N) | |
| 205 | Isomorphic Strings | [C#](./LeetCode/0201-0250/0205-IsomorphicStrings.cs)(72ms) | O(N) | O(1) | |
| 206 | Reverse Linked List | [C#](./LeetCode/0201-0250/0206-ReverseLinkedList.cs)(88ms) | O(N) | O(1) | |
| 207 | Course Schedule | [C#](./LeetCode/0201-0250/0207-CourseSchedule.cs)(116ms) | O(N<sup>2</sup> + E) | O(N<sup>2</sup>) | |
| 208 | Implement Trie (Prefix Tree) | [C#](./LeetCode/0201-0250/0208-ImplementTrie.cs)(184ms) | O(N) | O(N) | |
| 209 | Minimum Size Subarray Sum | [C#](./LeetCode/0201-0250/0209-MinimumSizeSubarraySum.cs)(100ms) | O(N) | O(1) | |
| 210 | Course Schedule II | [C#](./LeetCode/0201-0250/0210-CourseScheduleII.cs)(272ms) | O(N<sup>2</sup> + E) | O(N<sup>2</sup>) | |
| 211 | Add and Search Word - Data structure design | [C#](./LeetCode/0201-0250/0211-AddAndSearchWordDataStructureDesign.cs)(272ms) | O(1) | O(N) | |
| 212 | Word Search II | [C#](./LeetCode/0201-0250/0212-WordSearchII.cs)(272ms) | O(N*M) | O(K) | |
| 213 | House Robber II | [C#](./LeetCode/0201-0250/0213-HouseRobberII.cs)(84ms) | O(N) | O(1) | |
| 215 | Kth Largest Element in an Array | [C#](./LeetCode/0201-0250/0215-KthLargestElementInAnArray.cs)(100ms) | O(NLogN) | O(1) | |
| 216 | Combination Sum III | [C#](./LeetCode/0201-0250/0216-CombinationSumIII.cs)(200ms) | O(9! * K / (9-K)!) | O(K) | |
| 217 | Contains Duplicate | [C#](./LeetCode/0201-0250/0217-ContainsDuplicate.cs)(112ms) | O(N) | O(N) | |
| 218 | The Skyline Problem | [C#](./LeetCode/0201-0250/0218-TheSkylineProblem.cs)(288ms) | O(NLogN) | O(N) | |
| 219 | Contains Duplicate II | [C#](./LeetCode/0201-0250/0219-ContainsDuplicateII.cs)(100ms) | O(N) | O(N) | |
| 220 | Contains Duplicate III | [C#](./LeetCode/0201-0250/0220-ContainsDuplicateIII.cs)(100ms) | O(NlogN) | O(N) | |
| 221 | Maximal Square | [C#](./LeetCode/0201-0250/0221-MaximalSquare.cs)(112ms) | O(N*M) | O(N) | |
| 222 | Count Complete Tree Nodes | [C#](./LeetCode/0201-0250/0222-CountCompleteTreeNodes.cs)(112ms) | O(log<sup>2</sup>N) | O(1) | |
| 224 | Basic Calculator | [C#](./LeetCode/0201-0250/0224-BasicCalculator.cs)(80ms) | O(N) | O(N) | |
| 225 | Implement Stack using Queues | [C#](./LeetCode/0201-0250/0225-ImplementStackUsingQueues.cs)(92ms) | O(1) | O(N) | |
| 226 | Invert Binary Tree | [C#](./LeetCode/0201-0250/0226-InvertBinaryTree.cs)(92ms) | O(N) | O(1) | |
| 227 | Basic Calculator II | [C#](./LeetCode/0201-0250/0227-BasicCalculatorII.cs)(76ms) | O(N) | O(N) | |
| 229 | Majority Element II | [C#](./LeetCode/0201-0250/0229-MajorityElementII.cs)(240ms) | O(N) | O(1) | Boyer-Moore Voting Algorithm |
| 230 | Kth Smallest Element in a BST | [C#](./LeetCode/0201-0250/0230-KthSmallestElementInABST.cs)(96ms) | O(N) | O(N) | |
| 231 | Power of Two | [C#](./LeetCode/0201-0250/0231-PowerOfTwo.cs)(36ms) | O(1) | O(1) | |
| 232 | Implement Queue using Stacks | [C#](./LeetCode/0201-0250/0232-ImplementQueueUsingStacks.cs)(92ms) | | | |
| 234 | Palindrome Linked List | [C#](./LeetCode/0201-0250/0234-PalindromeLinkedList.cs)(100ms) | O(N) | O(1) | |
| 235 | Lowest Common Ancestor of a Binary Search Tree | [C#](./LeetCode/0201-0250/0235-LowestCommonAncestorOfABinarySearchTree.cs)(108ms) | O(h) | O(1) | |
| 236 | Lowest Common Ancestor of a Binary Tree | [C#](./LeetCode/0201-0250/0236-LowestCommonAncestorOfABinaryTree.cs)(100 ms) | O(N) | O(N) | |
| 237 | Delete Node in a Linked List | [C#](./LeetCode/0201-0250/0237-DeleteNodeInALinkedList.cs)(96ms) | O(1) | O(1) | |
| 238 | Product of Array Except Self | [C#](./LeetCode/0201-0250/0238-ProductOfArrayExceptSelf.cs)(260ms) | O(N) | O(1) | |
| 239 | Sliding Window Maximum | [C#](./LeetCode/0201-0250/0239-SlidingWindowMaximum.cs)(252ms) | O(N) | O(N) | |
| 240 | Search a 2D Matrix II | [C#](./LeetCode/0201-0250/0240-SearchA2DMatrixII.cs)(244ms) | O(LogN) | O(1) | |
| 242 | Valid Anagram | [C#](./LeetCode/0201-0250/0242-ValidAnagram.cs)(68ms) | O(N) | O(1) | |
| 243 | Shortest Word Distance | [C#](./LeetCode/0201-0250/0243-ShortestWordDistance.cs)(92ms) | O(N) | O(1) | |
| 246 | Strobogrammatic Number | [C#](./LeetCode/0201-0250/0246-StrobogrammaticNumber.cs)(68ms) | O(N) | O(1) | |

### Problems 251-300
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 252 | Meeting Rooms | [C#](./LeetCode/0251-0300/0252-MeetingRooms.cs)(100ms) | O(NlogN) | O(1) | |
| 253 | Meeting Rooms II | [C#](./LeetCode/0251-0300/0253-MeetingRoomsII.cs)(104ms) | O(NlogN) | O(N) | |
| 256 | Paint House | [C#](./LeetCode/0251-0300/0256-PaintHouse.cs)(88ms) | O(N) | O(1) | |
| 257 | Binary Tree Paths | [C#](./LeetCode/0251-0300/0257-BinaryTreePaths.cs)(248ms) | O(N) | O(N) | |
| 258 | Add Digits | [C#](./LeetCode/0251-0300/0258-AddDigits.cs)(36ms) | O(N) | O(1) | |
| 260 | Single Number III | [C#](./LeetCode/0251-0300/0260-SingleNumberIII.cs)(228ms) | O(N) | O(1) | |
| 263 | Ugly Number | [C#](./LeetCode/0251-0300/0263-UglyNumber.cs)(40ms) | O(1) | O(1) | |
| 264 | Ugly Number II | [C#](./LeetCode/0251-0300/0264-UglyNumberII.cs)(44ms) | O(N) | O(N) | |
| 266 | Palindrome Permutation | [C#](./LeetCode/0251-0300/0266-PalindromePermutation.cs)(68ms) | O(N) | O(1) | |
| 268 | Missing Number | [C#](./LeetCode/0251-0300/0268-MissingNumber.cs)(100ms) | O(N) | O(1) | |
| 269 | Alien Dictionary | [C#](./LeetCode/0251-0300/0269-AlienDictionary.cs)(100ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 270 | Closest Binary Search Tree Value | [C#](./LeetCode/0251-0300/0270-ClosestBinarySearchTreeValue.cs)(96ms) | O(logN) | O(logN) | |
| 271 | Encode and Decode Strings | [C#](./LeetCode/0251-0300/0271-EncodeAndDecodeStrings.cs)(284ms) | O(N) | O(N) | |
| 273 | Integer to English Words | [C#](./LeetCode/0251-0300/0273-IntegerToEnglishWords.cs)(80ms) | O(N) | O(N) | |
| 274 | H-Index | [C#](./LeetCode/0251-0300/0274-HIndex.cs)(84ms) | O(N) | O(N) | |
| 275 | H-Index II | [C#](./LeetCode/0251-0300/0275-HIndexII.cs)(112ms) | O(logN) | O(1) | |
| 276 | Paint Fence | [C#](./LeetCode/0251-0300/0276-PaintFence.cs)(36ms) | O(N*K) | O(N*K) | |
| 278 | First Bad Version | [C#](./LeetCode/0251-0300/0278-FirstBadVersion.cs)(40ms) | O(N) | O(1) | |
| 279 | Perfect Squares | [C#](./LeetCode/0251-0300/0279-PerfectSquares.cs)(84ms) | O(N) | O(N) | |
| 280 | Wiggle Sort | [C#](./LeetCode/0251-0300/0280-WiggleSort.cs)(260ms) | O(N) | O(1) | |
| 283 | Move Zeroes | [C#](./LeetCode/0251-0300/0283-MoveZeroes.cs)(240ms) | O(N) | O(1) | |
| 285 | Inorder Successor in BST | [C#](./LeetCode/0251-0300/0285-InorderSuccessorInBST.cs)(104ms) | O(N) | O(N) | |
| 287 | Find the Duplicate Number | [C#](./LeetCode/0251-0300/0287-FindTheDuplicateNumber.cs)(96ms) | O(N) | O(1) | |
| 289 | Game of Life | [C#](./LeetCode/0251-0300/0289-GameOfLife.cs) | O(NM) | O(1) | |
| 290 | Word Pattern | [C#](./LeetCode/0251-0300/0290-WordPattern.cs)(68ms) | O(N) | O(N) | |
| 292 | Nim Game | [C#](./LeetCode/0251-0300/0292-NimGame.cs)(36ms) | O(1) | O(1) | |
| 293 | Flip Game | [C#](./LeetCode/0251-0300/0293-FlipGame.cs)(220ms) | O(N) | O(N) | |
| 295 | Find Median from Data Stream | [C#](./LeetCode/0251-0300/0295-FindMedianFromDataStream.cs)(308ms) | O(LogN) | O(N) | |
| 297 | Serialize and Deserialize Binary Tree | [C#](./LeetCode/0251-0300/0297-SerializeandDeserializeBinaryTree.cs)(120ms) | O(N) | O(N) | |
| 299 | Bulls and Cows | [C#](./LeetCode/0251-0300/0299-BullsAndCows.cs)(84ms) | O(N) | O(1) | |
| 300 | Longest Increasing Subsequence | [C#](./LeetCode/0251-0300/0300-LongestIncreasingSubsequence.cs)(84ms) | O(NlogN) | O(N) | |

### Problems 301-350
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 301 | Remove Invalid Parentheses | [C#](./LeetCode/0301-0350/0301-RemoveInvalidParentheses.cs)(240ms) | O(2<sup>N</sup>) | O(N) | |
| 303 | Range Sum Query - Immutable | [C#](./LeetCode/0301-0350/0303-RangeSumQueryImmutable.cs)(140ms) | O(N) | O(N) | |
| 305 | Number of Islands II | [C#](./LeetCode/0301-0350/0305-NumberOfIslandsII.cs)(1900ms) | O(N*M+k<sup>2</sup>) | O(K) | |
| 309 | Best Time to Buy and Sell Stock with Cooldown | [C#](./LeetCode/0301-0350/0309-BestTimeToBuyAndSellStockWithCooldown.cs)(88ms) | O(N) | O(1) | |
| 311 | Sparse Matrix Multiplication | [C#](./LeetCode/0301-0350/0311-SparseMatrixMultiplication.cs)(260ms) | O(N * M * P) | O(N*P) | |
| 312 | Burst Balloons | [C#](./LeetCode/0301-0350/0312-BurstBalloons.cs)(104ms) | O(N<sup>3</sup>) | O(N<sup>2</sup>) | |
| 314 | Binary Tree Vertical Order Traversal | [C#](./LeetCode/0301-0350/0314-BinaryTreeVerticalOrderTraversal.cs)(288ms) | O(N) | O(N) | |
| 315 | Count of Smaller Numbers After Self | [C#](./LeetCode/0301-0350/0315-CountOfSmallerNumbersAfterSelf.cs)(256ms) | O(NlogN) | O(N) | BST |
| 316 | Remove Duplicate Letters | [C#](./LeetCode/0301-0350/0316-RemoveDuplicateLetters.cs)(84ms) | O(N) | O(N) | |
| 317 | Shortest Distance from All Buildings | [C#](./LeetCode/0301-0350/0317-ShortestDistanceFromAllBuildings.cs)(140ms) | O(N<sup>2</sup>M<sup>2</sup>) | O(N*M) | |
| 322 | Coin Change | [C#](./LeetCode/0301-0350/0322-CoinChange.cs)(108 ms) | O(N*S) | O(N) | |
| 326 | Power of Three | [C#](./LeetCode/0301-0350/0326-PowerOfThree.cs)(76ms) | O(1) | O(1) | |
| 327 | Count of Range Sum | [C#](./LeetCode/0301-0350/0327-CountOfRangeSum.cs)(108ms) | O(NLogN) | O(N) | |
| 328 | Odd Even Linked List | [C#](./LeetCode/0301-0350/0328-OddEvenLinkedList.cs)(92ms) | O(N) | O(1) | |
| 329 | Longest Increasing Path in a Matrix | [C#](./LeetCode/0301-0350/0329-LongestIncreasingPathInAMatrix.cs)(132ms) | O(M*N) | O(M*N) | |
| 332 | Reconstruct Itinerary | [C#](./LeetCode/0301-0350/0332-ReconstructItinerary.cs)(292ms) | O(NLogN) | O(N) | |
| 336 | Palindrome Pairs | [C#](./LeetCode/0301-0350/0336-PalindromePairs.cs)(620ms) | O(N<sup>2</sup>K) | O(N) | |
| 338 | Counting Bits | [C#](./LeetCode/0301-0350/0338-CountingBits.cs)(220ms) | O(N) | O(1) | |
| 339 | Nested List Weight Sum | [C#](./LeetCode/0301-0350/0339-NestedListWeightSum.cs)(60ms) | O(N) | O(N) | |
| 340 | Longest Substring with At Most K Distinct Characters | [C#](./LeetCode/0301-0350/0340-LongestSubstringWithAtMostKDistinctCharacters.cs)(88ms) | O(N) | O(N) | |
| 341 | Flatten Nested List Iterator | [C#](./LeetCode/0301-0350/0341-FlattenNestedListIterator.cs)(280ms) | O(1) | O(1) | |
| 342 | Power of Four | [C#](./LeetCode/0301-0350/0342-PowerOfFour.cs)(32ms) | O(1) | O(1) | |
| 344 | Reverse String | [C#](./LeetCode/0301-0350/0344-ReverseString.cs)(388ms) | O(N) | O(1) | |
| 345 | Reverse Vowels of a String | [C#](./LeetCode/0301-0350/0345-ReverseVowelsOfAString.cs)(88ms) | O(N) | O(1) | |
| 346 | Moving Average from Data Stream | [C#](./LeetCode/0301-0350/0346-MovingAverageFromDataStream.cs)(152ms) | O(1) | O(N) | |
| 347 | Top K Frequent Elements | [C#](./LeetCode/0301-0350/0347-TopKFrequentElements.cs)(256ms) | O(NLogN) | O(k) | |
| 348 | Design Tic-Tac-Toe | [C#](./LeetCode/0301-0350/0348-DesignTicTacToe.cs)(132ms) | O(1) | O(N) | |
| 349 | Intersection of Two Arrays | [C#](./LeetCode/0301-0350/0349-IntersectionOfTwoArrays.cs)(240ms) | O(N+M) | O(1) | |
| 350 | Intersection of Two Arrays II | [C#](./LeetCode/0301-0350/0350-IntersectionOfTwoArraysII.cs)(232ms) | O(N+M) | O(min(N, M)) | |

### Problems 351-400
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 352 | Data Stream as Disjoint Intervals | [C#](./LeetCode/0351-0400/0352-DataStreamAsDisjointIntervals.cs)(332ms) | O(logN) | O(N) | |
| 355 | Design Twitter | [C#](./LeetCode/0351-0400/0355-DesignTwitter.cs)(308ms) | O(1) | O(1) | |
| 359 | Logger Rate Limiter | [C#](./LeetCode/0351-0400/0359-LoggerRateLimiter.cs)(248ms) | O(N) | O(N) | |
| 362 | Design Hit Counter | [C#](./LeetCode/0351-0400/0362-DesignHitCounter.cs)(104ms) | O(1) | O(1) | |
| 364 | Nested List Weight Sum II | [C#](./LeetCode/0351-0400/0364-NestedListWeightSumII.cs)(68ms) | O(N) | O(N) | |
| 366 | Find Leaves of Binary Tree | [C#](./LeetCode/0351-0400/0366-FindLeavesOfBinaryTree.cs)(236ms) | O(N) | O(logN) | |
| 367 | Valid Perfect Square | [C#](./LeetCode/0351-0400/0367-ValidPerfectSquare.cs)(40ms) | O(logN) | O(1) | |
| 368 | Largest Divisible Subset | [C#](./LeetCode/0351-0400/0368-LargestDivisibleSubset.cs)(252ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 370 | Range Addition | [C#](./LeetCode/0351-0400/0370-RangeAddition.cs)(344ms) | O(N+K) | O(1) | |
| 371 | Sum of Two Integers | [C#](./LeetCode/0351-0400/0371-SumOfTwoIntegers.cs)(36ms) | O(1) | O(1) | |
| 374 | Guess Number Higher or Lower | [C#](./LeetCode/0351-0400/0374-GuessNumberHigherOrLower.cs)(40ms) | O(logN) | O(1) | |
| 375 | Guess Number Higher or Lower II | [C#](./LeetCode/0351-0400/0375-GuessNumberHigherOrLowerII.cs)(40ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 380 | Insert Delete GetRandom O(1) | [C#](./LeetCode/0351-0400/0380-InsertDeleteGetRandom.cs)(144ms) | O(N) | O(N) | |
| 381 | Insert Delete GetRandom O(1) - Duplicates allowed | [C#](./LeetCode/0351-0400/0381-InsertDeleteGetrandomDuplicatesAllowed.cs)(192ms) | O(N) | O(N) | |
| 383 | Ransom Note | [C#](./LeetCode/0351-0400/0383-RansomNote.cs)(72ms) | O(N) | O(1) | |
| 387 | First Unique Character in a String | [C#](./LeetCode/0351-0400/0387-FirstUniqueCharacterInAString.cs)(80ms) | O(N) | O(1) | |
| 389 | Find the Difference | [C#](./LeetCode/0351-0400/0389-FindTheDifference.cs)(84ms) | O(N) | O(1) | |
| 392 | Is Subsequence | [C#](./LeetCode/0351-0400/0392-IsSubsequence.cs)(76ms) | O(T) | O(1) | |
| 393 | UTF-8 Validation | [C#](./LeetCode/0351-0400/0393-UTF8Validation.cs) | O(N) | O(1) | |
| 394 | Decode String | [C#](./LeetCode/0351-0400/0394-DecodeString.cs)(80ms) | O(N) | O(N) | |
| 399 | Evaluate Division | [C#](./LeetCode/0351-0400/0399-EvaluateDivision.cs)(240ms) | O(N) | O(N) | |

### Problems 401-450
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 401 | Binary Watch | [C#](./LeetCode/0401-0450/0401-BinaryWatch.cs)(236ms) | O(1) | O(1) | |
| 402 | Remove K Digits | [C#](./LeetCode/0401-0450/0402-RemoveKDigits.cs)(84ms) | O(N) | O(N) | |
| 403 | Frog Jump | [C#](./LeetCode/0401-0450/0403-FrogJump.cs)(108ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 404 | Sum of Left Leaves | [C#](./LeetCode/0401-0450/0404-SumOfLeftLeaves.cs)(88ms) | O(N) | O(N) | |
| 405 | Convert a Number to Hexadecimal | [C#](./LeetCode/0401-0450/0405-ConvertANumberToHexadecimal.cs)(76ms) | O(log<sub>16</sub> N) | O(log<sub>16</sub> N) | |
| 406 | Queue Reconstruction by Height | [C#](./LeetCode/0401-0450/0406-QueueReconstructionByHeight.cs)(268ms) | O(N<sup>2</sup>) | O(N) | |
| 408 | Valid Word Abbreviation | [C#](./LeetCode/0401-0450/0408-ValidWordAbbreviation.cs)(72ms) | O(N) | O(1) | |
| 409 | Longest Palindrome | [C#](./LeetCode/0401-0450/0409-LongestPalindrome.cs)(72ms) | O(N) | O(1) | |
| 410 | Split Array Largest Sum | [C#](./LeetCode/0401-0450/0410-SplitArrayLargestSum.cs)(92ms) | O(N∗log(sum of array)) | O(1) | Binary Search |
| 412 | Fizz Buzz | [C#](./LeetCode/0401-0450/0412-FizzBuzz.cs)(216ms) | O(N) | O(N) | |
| 414 | Third Maximum Number | [C#](./LeetCode/0401-0450/0414-ThirdMaximumNumber.cs)(92ms) | O(NlogN) | O(1) | |
| 415 | Add Strings | [C#](./LeetCode/0401-0450/0415-AddStrings.cs)(84ms) | O(N) | O(N) | |
| 416 | Partition Equal Subset Sum | [C#](./LeetCode/0401-0450/0416-PartitionEqualSubsetSum.cs)(80ms) | O(2<sup>N</sup>) | O(N) | |
| 419 | Battleships in a Board | [C#](./LeetCode/0401-0450/0419-BattleshipsInABoard.cs)(100ms) | O(N) | O(1) | |
| 420 | Strong Password Checker | [C#](./LeetCode/0401-0450/0420-StrongPasswordChecker.cs)(72ms) | O(N) | O(N) | |
| 421 | Maximum XOR of Two Numbers in an Array | [C#](./LeetCode/0401-0450/0421-MaximumXOROfTwoNumbersInAnArray.cs)(152ms) | O(N) | O(N) | |
| 422 | Valid Word Square | [C#](./LeetCode/0401-0450/0422-ValidWordSquare.cs)(96ms) | O(N*M) | O(1) | |
| 425 | Word Squares | [C#](./LeetCode/0401-0450/0425-WordSquares.cs)(340ms) | O(N * 26^L * L) | O(N*L) | |
| 426 | Convert Binary Search Tree to Sorted Doubly Linked List | [C#](./LeetCode/0401-0450/0426-ConvertBinarySearchTreeToSortedDoublyLinkedList.cs)(96ms) | O(N) | O(logN) | |
| 427 | Construct Quad Tree | [C#](./LeetCode/0401-0450/0427-ConstructQuadTree.cs)(100ms) | O(N*N) | O(logN) | |
| 428 | Serialize and Deserialize N-ary Tree | [C#](./LeetCode/0401-0450/0428-SerializeAndDeserializeNAryTree.cs)(408ms) | O(N) | O(N) | |
| 429 | N-ary Tree Level Order Traversal | [C#](./LeetCode/0401-0450/0429-NAryTreeLevelOrderTraversal.cs)(296ms) | O(N) | O(H) | |
| 430 | Flatten a Multilevel Doubly Linked List | [C#](./LeetCode/0401-0450/0430-FlattenAMultilevelDoublyLinkedList.cs)(88ms) | O(N) | O(N) | |
| 432 | All O`one Data Structure | [C#](./LeetCode/0401-0450/0432-AllOOneDataStructure.cs)(180ms) | O(1) | O(N) | |
| 434 | Number of Segments in a String | [C#](./LeetCode/0401-0450/0434-NumberOfSegmentsInAString.cs)(68ms) | O(N) | O(1) | |
| 435 | Non-overlapping Intervals | [C#](./LeetCode/0401-0450/0435-NonOverlappingIntervals.cs)(96ms) | O(NlogN) | O(1) | |
| 436 | Find Right Interval | [C#](./LeetCode/0401-0450/0436-FindRightInterval.cs)(364ms) | O(NlogN) | O(N) | |
| 437 | Path Sum III | [C#](./LeetCode/0401-0450/0437-PathSumIII.cs) | O(N) | O(N) | |
| 438 | Find All Anagrams in a String | [C#](./LeetCode/0401-0450/0438-FindAllAnagramsInAString.cs)(244ms) | O(N) | O(1) | |
| 441 | Arranging Coins | [C#](./LeetCode/0401-0450/0441-ArrangingCoins.cs)(40ms) | O(1) | O(1) | |
| 442 | Find All Duplicates in an Array | [C#](./LeetCode/0401-0450/0442-FindAllDuplicatesInAnArray.cs)(368ms) | O(N) | O(1) | |
| 443 | String Compression | [C#](./LeetCode/0401-0450/0443-StringCompression.cs)(264ms) | O(N) | O(1) | |
| 445 | Add Two Numbers II | [C#](./LeetCode/0401-0450/0445-AddTwoNumbersII.cs)(108ms) | N(N) | O(1) | |
| 447 | Number of Boomerangs | [C#](./LeetCode/0401-0450/0447-NumberOfBoomerangs.cs)(244ms) | O(N<sup>2</sup>) | O(N) | |
| 448 | Find All Numbers Disappeared in an Array | [C#](./LeetCode/0401-0450/0448-FindAllNumbersDisappearedInAnArray.cs)(296ms) | O(N) | O(1) | |
| 449 | Serialize and Deserialize BST | [C#](./LeetCode/0401-0450/0449-SerializeAndDeserializeBST.cs)(112ms) | O(N) | O(N) | |
| 450 | Delete Node in a BST | [C#](./LeetCode/0401-0450/0450-DeleteNodeInABST.cs)(100ms) | O(logN) | O(logN) | |

### Problems 451-500
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 451 | Sort Characters By Frequency | [C#](./LeetCode/0451-0500/0451-SortCharactersByFrequency.cs)(108ms) | O(N) | O(N) | |
| 452 | Minimum Number of Arrows to Burst Balloons | [C#](./LeetCode/0451-0500/0452-MinimumNumberOfArrowsToBurstBalloons.cs)(212ms) | O(NlogN) | O(N) | |
| 453 | Minimum Moves to Equal Array Elements | [C#](./LeetCode/0451-0500/0453-MinimumMovesToEqualArrayElements.cs)(128ms) | O(N) | O(1) | |
| 455 | Assign Cookies | [C#](./LeetCode/0451-0500/0455-AssignCookies.cs)(116ms) | O(NlogN) | O(1) | |
| 458 | Poor Pigs | [C#](./LeetCode/0451-0500/0458-PoorPigs.cs)(36ms) | O(1) | O(1) | |
| 459 | Repeated Substring Pattern | [C#](./LeetCode/0451-0500/0459-RepeatedSubstringPattern.cs)(84ms) | O(N) | O(N) | |
| 460 | LFU Cache | [C#](./LeetCode/0451-0500/0460-LFUCache.cs)(268ms) | O(1) | O(1) | |
| 461 | Hamming Distance | [C#](./LeetCode/0451-0500/0461-HammingDistance.cs)(36ms) | O(1) | O(1) | |
| 463 | Island Perimeter | [C#](./LeetCode/0451-0500/0463-IslandPerimeter.cs)(176ms) | O(N*M) | O(1) | |
| 465 | Optimal Account Balancing | [C#](./LeetCode/0451-0500/0465-OptimalAccountBalancing.cs)(104ms) | O(2<sup>N</sup>) | O(N) | |
| 468 | Validate IP Address | [C#](./LeetCode/0451-0500/0468-ValidateIPAddress.cs)(84ms) | O(N) | O(1) | |
| 470 | Implement Rand10() Using Rand7() | [C#](./LeetCode/0451-0500/0470-ImplementRand10UsingRand7.cs)(228ms) | O(1) | O(1) | |
| 472 | Concatenated Words | [C#](./LeetCode/0451-0500/0472-ConcatenatedWords.cs)(576ms) | O(N<sup>2</sup>) | O(N) | |
| 475 | Heaters | [C#](./LeetCode/0451-0500/0475-Heaters.cs)(152ms) | O(NlogN) | O(N) | |
| 476 | Number Complement | [C#](./LeetCode/0451-0500/0476-NumberComplement.cs)(32ms) | O(1) | O(1) | |
| 480 | Sliding Window Median | [C#](./LeetCode/0451-0500/0480-SlidingWindowMedian.cs)(648ms) | O(NlogN) | O(K) | |
| 482 | License Key Formatting | [C#](./LeetCode/0451-0500/0482-LicenseKeyFormatting.cs)(96ms) | O(N) | O(N) | |
| 484 | Find Permutation | [C#](./LeetCode/0451-0500/0484-FindPermutation.cs)(236ms) | O(N) | O(1) | |
| 485 | Max Consecutive Ones | [C#](./LeetCode/0451-0500/0485-MaxConsecutiveOnes.cs)(136ms) | O(N) | O(1) | |
| 489 | Robot Room Cleaner | [C#](./LeetCode/0451-0500/0489-RobotRoomCleaner.cs)(112ms) | O(N) | O(N) | |
| 490 | The Maze | [C#](./LeetCode/0451-0500/0490-TheMaze.cs)(124ms) | O(NM) | O(NM) | |
| 492 | Construct the Rectangle | [C#](./LeetCode/0451-0500/0492-ConstructTheRectangle.cs)(200ms) | O(sqrt(N)) | O(1) | |
| 493 | Reverse Pairs | [C#](./LeetCode/0451-0500/0493-ReversePairs.cs)(248ms) | O(NlogN) | O(N) | |
| 495 | Teemo Attacking | [C#](./LeetCode/0451-0500/0495-TeemoAttacking.cs)(124ms) | O(N) | O(1) | |
| 496 | Next Greater Element I | [C#](./LeetCode/0451-0500/0496-NextGreaterElementI.cs)(236ms) | O(N) | O(N) | |
| 497 | Random Point in Non-overlapping Rectangles | [C#](./LeetCode/0451-0500/0497-RandomPointInNonOverlappingRectangles.cs)(324ms) | O(N) | O(N) | |
| 498 | Diagonal Traverse | [C#](./LeetCode/0451-0500/0498-DiagonalTraverse.cs)(288ms) | O(N*M) | O(1) | |
| 500 | Keyboard Row | [C#](./LeetCode/0451-0500/0500-KeyboardRow.cs)(236ms) | O(N) | O(1) | |

### Problems 501-550
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 501 | Find Mode in Binary Search Tree | [C#](./LeetCode/0501-0550/0501-FindModeInBinarySearchTree.cs)(240ms) | O(N) | O(1) | |
| 503 | Next Greater Element II | [C#](./LeetCode/0501-0550/0503-NextGreaterElementII.cs)(344ms) | O(N) | O(N) | |
| 504 | Base 7 | [C#](./LeetCode/0501-0550/0504-Base7.cs)(76ms) | O(1) | O(1) | |
| 506 | Relative Ranks | [C#](./LeetCode/0501-0550/0506-RelativeRanks.cs)(260ms) | O(N) | O(N) | |
| 507 | Perfect Number | [C#](./LeetCode/0501-0550/0507-PerfectNumber.cs)(36ms) | O(1) | O(1) | |
| 509 | Fibonacci Number | [C#](./LeetCode/0501-0550/0509-FibonacciNumber.cs)(40ms) | O(N) | O(1) | |
| 510 | Inorder Successor in BST II | [C#](./LeetCode/0501-0550/0510-InorderSuccessorInBSTII.cs)(112ms) | O(logN) | O(1) | |
| 513 | Find Bottom Left Tree Value | [C#](./LeetCode/0501-0550/0513-FindBottomLeftTreeValue.cs)(112ms) | O(N) | O(N) | |
| 515 | Find Largest Value in Each Tree Row | [C#](./LeetCode/0501-0550/0515-FindLargestValueInEachTreeRow.cs)(248ms) | O(N) | O(N) | |
| 518 | Coin Change 2 | [C#](./LeetCode/0501-0550/0518-CoinChange2.cs)(92ms) | O(N) | O(N) | |
| 520 | Detect Capital | [C#](./LeetCode/0501-0550/0520-DetectCapital.cs)(72ms) | O(N) | O(N) | |
| 521 | Longest Uncommon Subsequence I | [C#](./LeetCode/0501-0550/0521-LongestUncommonSubsequenceI.cs)(68ms) | O(N) | O(1) | Stupid question... |
| 523 | Continuous Subarray Sum | [C#](./LeetCode/0501-0550/0523-ContinuousSubarraySum.cs)(120ms) | O(N) | O(min(N,k)) | |
| 525 | Word Abbreviation | [C#](./LeetCode/0501-0550/0525-ContiguousArray.cs)(216ms) | O(N) | O(N) | |
| 528 | Random Pick with Weight | [C#](./LeetCode/0501-0550/0528-RandomPickWithWeight.cs)(208ms) | O(logN) | O(N) | |
| 529 | Minesweeper | [C#](./LeetCode/0501-0550/0529-Minesweeper.cs)(380ms) | O(N*M) | O(N+M) | |
| 530 | Minimum Absolute Difference in BST | [C#](./LeetCode/0501-0550/0530-MinimumAbsoluteDifferenceInBST.cs)(100ms) | O(N) | O(logN) | |
| 532 | K-diff Pairs in an Array | [C#](./LeetCode/0501-0550/0532-KDiffPairsInAnArray.cs)(148ms) | O(N) | O(N) | |
| 535 | Encode and Decode TinyURL | [C#](./LeetCode/0501-0550/0535-EncodeAndDecodeTinyURL.cs)(88ms) | O(1) | O(N) | |
| 537 | Complex Number Multiplication | [C#](./LeetCode/0501-0550/0537-ComplexNumberMultiplication.cs)(84ms) | O(N) | O(1) | |
| 538 | Convert BST to Greater Tree | [C#](./LeetCode/0501-0550/0538-ConvertBSTToGreaterTree.cs)(104ms) | O(N) | O(N) | |
| 540 | Single Element in a Sorted Array | [C#](./LeetCode/0501-0550/0540-SingleElementInASortedArray.cs)(92ms) | O(logN) | O(1) | |
| 541 | Reverse String II | [C#](./LeetCode/0501-0550/0541-ReverseStringII.cs)(84ms) | O(N) | O(1) | |
| 543 | Diameter of Binary Tree | [C#](./LeetCode/0501-0550/0543-DiameterOfBinaryTree.cs)(96ms) | O(N) | O(N) | |
| 544 | Output Contest Matches | [C#](./LeetCode/0501-0550/0544-OutputContestMatches.cs)(80ms) | O(N) | O(N) | |
| 545 | Boundary of Binary Tree | [C#](./LeetCode/0501-0550/0545-BoundaryOfBinaryTree.cs)(240ms) | O(N) | O(N) | |
| 547 | Friend Circles | [C#](./LeetCode/0501-0550/0547-FriendCircles.cs)(112ms) | O(N<sup>2</sup>) | O(N) | |

### Problems 551-600
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 551 | Student Attendance Record I | [C#](./LeetCode/0551-0600/0551-StudentAttendanceRecordI.cs)(76ms) | O(N) | O(1) | |
| 552 | Student Attendance Record II | [C#](./LeetCode/0551-0600/0552-StudentAttendanceRecordII.cs)(100ms) | O(N) | O(N) | |
| 557 | Reverse Words in a String III | [C#](./LeetCode/0551-0600/0557-ReverseWordsInAStringIII.cs)(92ms) | O(N) | O(N) | |
| 559 | Maximum Depth of N-ary Tree | [C#](./LeetCode/0551-0600/0559-MaximumDepthOfNAryTree.cs)(408ms) | O(N) | O(N) | |
| 560 | Subarray Sum Equals K | [C#](./LeetCode/0551-0600/0560-SubarraySumEqualsK.cs)(104ms) | O(N) | O(1) | |
| 561 | Array Partition I | [C#](./LeetCode/0551-0600/0561-ArrayPartitionI.cs)(156ms) | O(NlogN) | O(1) | |
| 563 | Binary Tree Tilt | [C#](./LeetCode/0551-0600/0563-BinaryTreeTilt.cs)(104ms) | O(N) | O(N) | |
| 566 | Reshape the Matrix | [C#](./LeetCode/0551-0600/0566-ReshapeTheMatrix.cs)(260ms) | O(M*N) | O(M*N) | |
| 567 | Permutation in String | [C#](./LeetCode/0551-0600/0567-PermutationInString.cs)(92ms) | O(N) | O(1) | |
| 572 | Subtree of Another Tree | [C#](./LeetCode/0551-0600/0572-SubtreeOfAnotherTree.cs)(104ms) | O(N*M) | O(N) | |
| 575 | Distribute Candies | [C#](./LeetCode/0551-0600/0575-DistributeCandies.cs)(264ms) | O(N) | O(N) | |
| 581 | Shortest Unsorted Continuous Subarray | [C#](./LeetCode/0551-0600/0581-ShortestUnsortedContinuousSubarray.cs)(116ms) | O(N) | O(1) | |
| 582 | Kill Process | [C#](./LeetCode/0551-0600/0582-KillProcess.cs)(340ms) | O(N) | O(N) | |
| 588 | Design In-Memory File System | [C#](./LeetCode/0551-0600/0588-DesignInMemoryFileSystem.cs)(300ms) | O(logN) | O(N) | |
| 589 | N-ary Tree Preorder Traversal | [C#](./LeetCode/0551-0600/0589-NAryTreePreorderTraversal.cs)(292ms) | O(N) | O(N) | |
| 590 | N-ary Tree Postorder Traversal | [C#](./LeetCode/0551-0600/0590-NAryTreePostorderTraversal.cs)(280ms) | O(N) | O(N) | |
| 594 | Longest Harmonious Subsequence | [C#](./LeetCode/0551-0600/0594-LongestHarmoniousSubsequence.cs)(148ms) | O(N) | O(N) | |
| 598 | Range Addition II | [C#](./LeetCode/0551-0600/0598-RangeAdditionII.cs)(100ms) | O(N) | O(1) | |
| 599 | Minimum Index Sum of Two Lists | [C#](./LeetCode/0551-0600/0599-MinimumIndexSumOfTwoLists.cs)(296ms) | O(N+N) | O(min(N, M)) | |

### Problems 601-650
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 604 | Design Compressed String Iterator | [C#](./LeetCode/0601-0650/0604-DesignCompressedStringIterator.cs)(160ms) | O(N) | O(N) | |
| 605 | Can Place Flowers | [C#](./LeetCode/0601-0650/0605-CanPlaceFlowers.cs)(108ms) | O(N) | O(1) | |
| 606 | Construct String from Binary Tree | [C#](./LeetCode/0601-0650/0606-ConstructStringFromBinaryTree.cs)(120ms) | O(N) | O(N) | |
| 609 | Find Duplicate File in System | [C#](./LeetCode/0601-0650/0609-FindDuplicateFileInSystem.cs)(312ms) | O(N) | O(N) | |
| 616 | Add Bold Tag in String | [C#](./LeetCode/0601-0650/0616-AddBoldTagInString.cs)(112ms) | | | |
| 617 | Merge Two Binary Trees | [C#](./LeetCode/0601-0650/0617-MergeTwoBinaryTrees.cs)(112ms) | O(N) | O(1) | |
| 621 | Task Scheduler | [C#](./LeetCode/0601-0650/0621-TaskScheduler.cs)(180ms) | O(N) | O(1) | |
| 624 | Maximum Distance in Arrays | [C#](./LeetCode/0601-0650/0624-MaximumDistanceInArrays.cs)(116ms) | O(N*M) | O(1) | |
| 628 | Maximum Product of Three Numbers | [C#](./LeetCode/0601-0650/0628-MaximumProductOfThreeNumbers.cs)(132ms) | O(N) | O(1) | |
| 633 | Sum of Square Numbers | [C#](./LeetCode/0601-0650/0633-SumOfSquareNumbers.cs)(36ms) | O(logN) | O(1) | |
| 636 | Exclusive Time of Functions | [C#](./LeetCode/0601-0650/0636-ExclusiveTimeOfFunctions.cs)(272ms) | O(N) | O(N) | |
| 637 | Average of Levels in Binary Tree | [C#](./LeetCode/0601-0650/0637-AverageOfLevelsInBinaryTree.cs)(244ms) | O(N) | O(N) | |
| 642 | Design Search Autocomplete System | [C#](./LeetCode/0601-0650/0642-DesignSearchAutocompleteSystem.cs)(820ms) | O(N*k), O(p+q+mlogm) | O(N*k) | use Trie |
| 643 | Maximum Average Subarray I | [C#](./LeetCode/0601-0650/0643-MaximumAverageSubarrayI.cs)(236ms) | O(N) | O(1) | |
| 645 | Set Mismatch | [C#](./LeetCode/0601-0650/0645-SetMismatch.cs)(252ms) | | | |
| 647 | Palindromic Substrings | [C#](./LeetCode/0601-0650/0647-PalindromicSubstrings.cs)(68ms) | O(N) | O(N) | |

### Problems 651-700
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 653 | Two Sum IV - Input is a BST | [C#](./LeetCode/0651-0700/0653-TwoSumIVInputIsABST.cs)(112ms) | O(N) | O(N) | |
| 654 | Maximum Binary Tree | [C#](./LeetCode/0651-0700/0654-MaximumBinaryTree.cs)(116ms) | O(N) | O(1) | |
| 657 | Robot Return to Origin | [C#](./LeetCode/0651-0700/0657-RobotReturnToOrigin.cs)(76ms) | O(N) | O(1) | |
| 661 | Image Smoother | [C#](./LeetCode/0651-0700/0661-ImageSmoother.cs)(320ms) | O(N) | O(N) | |
| 662 | Maximum Width of Binary Tree | [C#](./LeetCode/0651-0700/0662-MaximumWidthOfBinaryTree.cs)(88ms) | O(N) | O(N) | |
| 665 | Non-decreasing Array | [C#](./LeetCode/0651-0700/0665-NonDecreasingArray.cs)(116ms) | O(N) | O(1) | |
| 668 | Kth Smallest Number in Multiplication Table | [C#](./LeetCode/0651-0700/0668-KthSmallestNumberInMultiplicationTable.cs)(52ms) | O(M*Log(N*M)) | O(1) | |
| 669 | Trim a Binary Search Tree | [C#](./LeetCode/0651-0700/0669-TrimABinarySearchTree.cs)(100ms) | O(N) | O(1) | |
| 671 | Second Minimum Node In a Binary Tree | [C#](./LeetCode/0651-0700/0671-SecondMinimumNodeInABinaryTree.cs)(88ms) | O(N) | O(N) | |
| 674 | Longest Continuous Increasing Subsequence | [C#](./LeetCode/0651-0700/0674-LongestContinuousIncreasingSubsequence.cs)(88ms) | O(N) | O(1) | |
| 678 | Valid Parenthesis String | [C#](./LeetCode/0651-0700/0678-ValidParenthesisString.cs)(68ms) | O(N) | O(1) | |
| 680 | Valid Palindrome II | [C#](./LeetCode/0651-0700/0680-ValidPalindromeII.cs)(96ms) | O(N) | O(1) | |
| 681 | Next Closest Time | [C#](./LeetCode/0651-0700/0681-NextClosestTime.cs)(92ms) | O(1) | O(1) | |
| 682 | Baseball Game | [C#](./LeetCode/0651-0700/0682-BaseballGame.cs)(92ms) | O(N) | O(N) | |
| 683 | K Empty Slots | [C#](./LeetCode/0651-0700/0683-KEmptySlots.cs)(260ms) | O(N) | O(N) | |
| 686 | Repeated String Match | [C#](./LeetCode/0651-0700/0686-RepeatedStringMatch.cs)(76ms) | O(N+M) | O(1) | |
| 687 | Longest Univalue Path | [C#](./LeetCode/0651-0700/0687-LongestUnivaluePath.cs)(172ms) | O(N) | O(logN) | |
| 690 | Employee Importance | [C#](./LeetCode/0651-0700/0690-EmployeeImportance.cs)(72ms) | O(N) | O(N) | |
| 692 | Top K Frequent Words | [C#](./LeetCode/0651-0700/0692-TopKFrequentWords.cs)(272ms) | O(NlogK) | O(N) | |
| 693 | Binary Number with Alternating Bits | [C#](./LeetCode/0651-0700/0693-BinaryNumberWithAlternatingBits.cs)(40ms) | O(1) | O(1) | |
| 695 | Max Area of Island | [C#](./LeetCode/0651-0700/0695-MaxAreaOfIsland.cs)(104ms) | O(N*M) | O(N*M) | |
| 696 | Count Binary Substrings | [C#](./LeetCode/0651-0700/0696-CountBinarySubstrings.cs)(84ms) | O(N) | O(1) | |
| 697 | Degree of an Array | [C#](./LeetCode/0651-0700/0697-DegreeOfAnArray.cs)(132ms) | O(N) | O(N) | |
| 698 | Partition to K Equal Sum Subsets | [C#](./LeetCode/0651-0700/0698-PartitionToKEqualSumSubsets.cs)(80ms) | O(N*2<sup>N</sup>) | O(2<sup>N</sup>) | |
| 700 | Search in a Binary Search Tree | [C#](./LeetCode/0651-0700/0700-SearchInABinarySearchTree.cs)(112ms) | O(logN) | O(logN) | |

### Problems 701-750
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 701 | Insert into a Binary Search Tree | [C#](./LeetCode/0701-0750/0701-InsertIntoABinarySearchTree.cs)(128ms) | O(logN) | O(1) | |
| 702 | Search in a Sorted Array of Unknown Size | [C#](./LeetCode/0701-0750/0702-SearchInASortedArrayOfUnknownSize.cs)(160ms) | O(logN) | O(1) | |
| 703 | Kth Largest Element in a Stream | [C#](./LeetCode/0701-0750/0703-KthLargestElementInAStream.cs)(200ms) | O(KlogK) | O(K) | |
| 704 | Binary Search | [C#](./LeetCode/0701-0750/0704-BinarySearch.cs)(120ms) | O(logN) | O(1) | |
| 705 | Design HashSet | [C#](./LeetCode/0701-0750/0705-DesignHashset.cs)(228ms) | | | |
| 706 | Design HashMap | [C#](./LeetCode/0701-0750/0706-DesignHashmap.cs)(260ms) | | | |
| 708 | Insert into a Sorted Circular Linked List | [C#](./LeetCode/0701-0750/0708-InsertIntoASortedCircularLinkedList.cs)(92ms) | O(N) | O(1) | |
| 709 | To Lower Case | [C#](./LeetCode/0701-0750/0709-ToLowerCase.cs)(76ms) | O(N) | O(1) | |
| 713 | Subarray Product Less Than K | [C#](./LeetCode/0701-0750/0713-SubarrayProductLessThanK.cs)(236ms) | O(N) | O(1) | |
| 715 | Range Module | [C#](./LeetCode/0701-0750/0715-RangeModule.cs)(488ms) | O(N) | O(N) | |
| 716 | Max Stack | [C#](./LeetCode/0701-0750/0716-MaxStack.cs)(188ms) | O(1) | O(N) | |
| 717 | 1-bit and 2-bit Characters | [C#](./LeetCode/0701-0750/0717-1BitAnd2BitCharacters.cs)(84ms) | O(N) | O(1) | |
| 720 | Longest Word in Dictionary | [C#](./LeetCode/0701-0750/0720-LongestWordInDictionary.cs)(112ms) | O(N) | O(N) | |
| 721 | Accounts Merge | [C#](./LeetCode/0701-0750/0721-AccountsMerge.cs)(468ms) | O(NlogN) | O(N) | |
| 722 | Remove Comments | [C#](./LeetCode/0701-0750/0722-RemoveComments.cs)(232ms) | O(N) | O(N) | |
| 723 | Candy Crush | [C#](./LeetCode/0701-0750/0723-CandyCrush.cs)(260ms) | O((R*C)<sup>2</sup>) | O(1) | |
| 724 | Find Pivot Index | [C#](./LeetCode/0701-0750/0724-FindPivotIndex.cs)(100ms) | O(N) | O(1) | |
| 726 | Number of Atoms | [C#](./LeetCode/0701-0750/0726-NumberOfAtoms.cs)(96ms) | O(N<sup>2</sup>) | O(N) | |
| 727 | Minimum Window Subsequence | [C#](./LeetCode/0701-0750/0727-MinimumWindowSubsequence.cs)(180ms) | O(NM) | O(NM) | |
| 728 | Self Dividing Numbers | [C#](./LeetCode/0701-0750/0728-SelfDividingNumbers.cs)(196ms) | | | |
| 733 | Flood Fill | [C#](./LeetCode/0701-0750/0733-FloodFill.cs)(248ms) | O(N) | O(N) | |
| 734 | Sentence Similarity | [C#](./LeetCode/0701-0750/0734-SentenceSimilarity.cs)(96ms) | O(N+P) | O(P) | |
| 735 | Asteroid Collision | [C#](./LeetCode/0701-0750/0735-AsteroidCollision.cs)(264ms) | O(N) | O(N) | |
| 739 | Daily Temperatures | [C#](./LeetCode/0701-0750/0739-DailyTemperatures.cs)(328ms) | O(N) | O(N) | |
| 742 | Closest Leaf in a Binary Tree | [C#](./LeetCode/0701-0750/0742-ClosestLeafInABinaryTree.cs)(124ms) | O(N) | O(N) | |
| 743 | Network Delay Time | [C#](./LeetCode/0701-0750/0743-NetworkDelayTime.cs)(236ms) | O(N<sup>2</sup> + E) | O(N + E) | Dijkstra's Algorithm |
| 744 | Find Smallest Letter Greater Than Target | [C#](./LeetCode/0701-0750/0744-FindSmallestLetterGreaterThanTarget.cs)(116ms) | O(logN) | O(1) | |
| 746 | Min Cost Climbing Stairs | [C#](./LeetCode/0701-0750/0746-MinCostClimbingStairs.cs)(88ms) | O(N) | O(1) | |
| 747 | Largest Number At Least Twice of Others | [C#](./LeetCode/0701-0750/0747-LargestNumberAtLeastTwiceOfOthers.cs)(84ms) | O(N) | O(1) | |
| 748 | Shortest Completing Word | [C#](./LeetCode/0701-0750/0748-ShortestCompletingWord.cs)(104ms) | O(N) | O(length) | |
| 750 | Number Of Corner Rectangles | [C#](./LeetCode/0701-0750/0750-NumberOfCornerRectangles.cs)(340ms) | O(N<sup>2</sup>*M) | O(N*M) | |

### Problems 751-800
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 751 | IP to CIDR | [C#](./LeetCode/0751-0800/0751-IPToCIDR.cs)(244ms) | O(N) | O(N) | |
| 753 | Cracking the Safe | [C#](./LeetCode/0751-0800/0753-CrackingtheSafe.cs)(120ms) | O(N*k<sup>N</sup>) | O(N*k<sup>N</sup>) | |
| 758 | Bold Words in String | [C#](./LeetCode/0751-0800/0758-BoldWordsInString.cs)(108ms) | O(N*M) | O(N) | |
| 759 | Employee Free Time | [C#](./LeetCode/0751-0800/0759-EmployeeFreeTime.cs)(432ms) | O(NlogN) | O(N) | |
| 760 | Find Anagram Mappings | [C#](./LeetCode/0751-0800/0760-FindAnagramMappings.cs)(236ms) | O(N^2) | O(N) | |
| 762 | Prime Number of Set Bits in Binary Representation | [C#](./LeetCode/0751-0800/0762-PrimeNumberOfSetBitsInBinaryRepresentation.cs)(48ms) | O(N) | O(1) | |
| 763 | Partition Labels | [C#](./LeetCode/0751-0800/0763-PartitionLabels.cs)(224ms) | O(N) | O(1) | |
| 765 | Couples Holding Hands | [C#](./LeetCode/0751-0800/0765-CouplesHoldingHands.cs)(92ms) | O(N) | O(N) | |
| 766 | Toeplitz Matrix | [C#](./LeetCode/0751-0800/0766-ToeplitzMatrix.cs)(96ms) | O(M*N) | O(1) | |
| 767 | Reorganize String | [C#](./LeetCode/0751-0800/0767-ReorganizeString.cs)(84ms) | O(N) | O(1) | |
| 771 | Jewels and Stones | [C#](./LeetCode/0751-0800/0771-JewelsAndStones.cs)(68ms) | O(N+M) | O(N) | |
| 772 | Basic Calculator III | [C#](./LeetCode/0751-0800/0772-BasicCalculatorIII.cs)(76ms) | O(N) | O(N) | |
| 773 | Sliding Puzzle | [C#](./LeetCode/0751-0800/0773-SlidingPuzzle.cs)(112ms) | O(N*M*(N*M)!) | O(N*M*(N*M)!) | |
| 777 | Swap Adjacent in LR String | [C#](./LeetCode/0751-0800/0777-SwapAdjacentInLRString.cs)(72ms) | O(N) | O(1) | |
| 780 | Reaching Points | [C#](./LeetCode/0751-0800/0780-ReachingPoints.cs)(40ms) | O(log(max(tx, ty))) | O(1) | |
| 783 | Minimum Distance Between BST Nodes | [C#](./LeetCode/0751-0800/0783-MinimumDistanceBetweenBSTNodes.cs)(84ms) | O(N) | O(logN) | |
| 784 | Letter Case Permutation | [C#](./LeetCode/0751-0800/0784-LetterCasePermutation.cs)(252ms) | O(2<sup>N</sup> + N) | O(2<sup>N</sup> + N) | |
| 787 | Cheapest Flights Within K Stops | [C#](./LeetCode/0751-0800/0787-CheapestFlightsWithinKStops.cs)(124ms) | O(E*K) | O(V<sup>2</sup>+V*K) | |
| 788 | Rotated Digits | [C#](./LeetCode/0751-0800/0788-RotatedDigits.cs)(36ms) | O(logN) | O(logN) | |
| 791 | Custom Sort String | [C#](./LeetCode/0751-0800/0791-CustomSortString.cs)(104ms) | O(N*M) | O(N) | |
| 794 | Valid Tic-Tac-Toe State | [C#](./LeetCode/0751-0800/0794-ValidTicTacToeState.cs)(88ms) | O(1) | O(1) | |
| 796 | Rotate String | [C#](./LeetCode/0751-0800/0796-RotateString.cs)(72ms) | O(N) | O(N) | Use Knuth–Morris–Pratt Algorithm |
| 797 | All Paths From Source to Target | [C#](./LeetCode/0751-0800/0797-AllPathsFromSourceToTarget.cs)(268ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 800 | Similar RGB Color | [C#](./LeetCode/0751-0800/0800-SimilarRGBColor.cs)(84ms) | O(1) | O(1) | |

### Problems 801-850
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 804 | Unique Morse Code Words | [C#](./LeetCode/0801-0850/0804-UniqueMorseCodeWords.cs)(92ms) | | | |
| 806 | Number of Lines To Write String | [C#](./LeetCode/0801-0850/0806-NumberOfLinesToWriteString.cs)(228ms) | O(N) | O(1) | |
| 807 | Max Increase to Keep City Skyline | [C#](./LeetCode/0801-0850/0807-MaxIncreaseToKeepCitySkyline.cs)(96ms) | O(N<sup>2</sup>) | O(N) | |
| 809 | Expressive Words | [C#](./LeetCode/0801-0850/0809-ExpressiveWords.cs)(92ms) | O(NK) | O(N) | |
| 811 | Subdomain Visit Count | [C#](./LeetCode/0801-0850/0811-SubdomainVisitCount.cs)(256ms) | O(N) | O(N) | |
| 812 | Largest Triangle Area | [C#](./LeetCode/0801-0850/0812-LargestTriangleArea.cs)(92ms) | O(N<sup>3</sup>) | O(1) | |
| 814 | Binary Tree Pruning | [C#](./LeetCode/0801-0850/0814-BinaryTreePruning.cs)(88ms) | O(N) | O(logN) | |
| 818 | Race Car | [C#](./LeetCode/0801-0850/0818-RaceCar.cs)(40ms) | O(NlogN) | O(T) | |
| 819 | Most Common Word | [C#](./LeetCode/0801-0850/0819-MostCommonWord.cs)(112ms) | O(N) | O(N) | |
| 821 | Shortest Distance to a Character | [C#](./LeetCode/0801-0850/0821-ShortestDistanceToACharacter.cs)(224ms) | O(N) | O(N) | |
| 824 | Goat Latin | [C#](./LeetCode/0801-0850/0824-GoatLatin.cs)(84ms) | O(N) | O(N) | |
| 829 | Consecutive Numbers Sum | [C#](./LeetCode/0801-0850/0829-ConsecutiveNumbersSum.cs)(40ms) | O(sqrt(N)) | O(1) | |
| 830 | Positions of Large Groups | [C#](./LeetCode/0801-0850/0830-PositionsOfLargeGroups.cs)(236ms) | O(N) | O(1) | |
| 832 | Flipping an Image | [C#](./LeetCode/0801-0850/0832-FlippingAnImage.cs)(240ms) | O(N) | O(1) | |
| 833 | Find And Replace in String | [C#](./LeetCode/0801-0850/0833-FindAndReplaceInString.cs)(104ms) | O(N) | O(N) | |
| 835 | Image Overlap | [C#](./LeetCode/0801-0850/0835-ImageOverlap.cs)(92ms) | O(N<sup>4</sup>) | O(1) | |
| 836 | Rectangle Overlap | [C#](./LeetCode/0801-0850/0836-RectangleOverlap.cs)(108ms) | O(1) | O(1) | |
| 837 | New 21 Game | [C#](./LeetCode/0801-0850/0837-New21Game.cs)(44ms) | O(N+W) | O(N+W) | |
| 840 | Magic Squares In Grid | [C#](./LeetCode/0801-0850/0840-MagicSquaresInGrid.cs)(88ms) | O(N*M) | O(1) | |
| 841 | Keys and Rooms | [C#](./LeetCode/0801-0850/0841-KeysAndRooms.cs)(108ms) | O(N+E) | O(N) | |
| 843 | Guess the Word | [C#](./LeetCode/0801-0850/0843-GuesstheWord.cs)(92ms) | O(N<sup>2</sup>) | O(N) | |
| 844 | Backspace String Compare | [C#](./LeetCode/0801-0850/0844-BackspaceStringCompare.cs)(64ms) | O(M+N) | O(1) | |
| 846 | Hand of Straights | [C#](./LeetCode/0801-0850/0846-HandOfStraights.cs)(264ms) | O(NlogN) | O(N) | |
| 849 | Maximize Distance to Closest Person | [C#](./LeetCode/0801-0850/0849-MaximizeDistanceToClosestPerson.cs)(100ms) | | | |

### Problems 851-900
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 852 | Peak Index in a Mountain Array | [C#](./LeetCode/0851-0900/0852-PeakIndexInAMountainArray.cs)(96ms) | O(LogN) | O(1) | |
| 856 | Score of Parentheses | [C#](./LeetCode/0851-0900/0856-ScoreOfParentheses.cs)(72ms) | O(N) | O(1) | |
| 857 | Minimum Cost to Hire K Workers | [C#](./LeetCode/0851-0900/0857-MinimumCostToHireKWorkers.cs)(156ms) | O(NLogN) | O(N) | |
| 859 | Buddy Strings | [C#](./LeetCode/0851-0900/0859-BuddyStrings.cs)(72ms) | O(N) | O(1) | |
| 860 | Lemonade Change | [C#](./LeetCode/0851-0900/0860-LemonadeChange.cs)(108ms) | O(N) | O(1) | |
| 861 | Score After Flipping Matrix | [C#](./LeetCode/0851-0900/0861-ScoreAfterFlippingMatrix.cs)(92ms) | O(N) | O(1) | |
| 863 | All Nodes Distance K in Binary Tree | [C#](./LeetCode/0851-0900/0863-AllNodesDistanceKInBinaryTree.cs)(240ms) | O(N) | O(N) | |
| 865 | Smallest Subtree with all the Deepest Nodes | [C#](./LeetCode/0851-0900/0865-SmallestSubtreeWithAllTheDeepestNodes.cs)(96ms) | O(N) | O(N) | |
| 867 | Transpose Matrix | [C#](./LeetCode/0851-0900/0867-TransposeMatrix.cs)(252ms) | O(N*M) | O(N*M) | |
| 868 | Binary Gap | [C#](./LeetCode/0851-0900/0868-BinaryGap.cs)(32ms) | O(logN) | O(1) | |
| 872 | Leaf-Similar Trees | [C#](./LeetCode/0851-0900/0872-LeafSimilarTrees.cs)(92ms) | O(N) | O(N) | |
| 874 | Walking Robot Simulation | [C#](./LeetCode/0851-0900/0874-WalkingRobotSimulation.cs)(216ms) | O(N+M) | O(M) | |
| 876 | Middle of the Linked List | [C#](./LeetCode/0851-0900/0876-MiddleOfTheLinkedList.cs)(84ms) | O(N) | O(1) | |
| 877 | Stone Game | [C#](./LeetCode/0851-0900/0877-StoneGame.cs)(92ms) | O(N) | O(N) | |
| 883 | Projection Area of 3D Shapes | [C#](./LeetCode/0851-0900/0883-ProjectionAreaOf3DShapes.cs)(92ms) | O(N*M) | O(1) | |
| 884 | Uncommon Words from Two Sentences | [C#](./LeetCode/0851-0900/0884-UncommonWordsFromTwoSentences.cs)(232ms) | O(N) | O(N) | |
| 885 | Spiral Matrix III | [C#](./LeetCode/0851-0900/0885-SpiralMatrixIII.cs)(228ms) | O(max(R, C)<sup>2</sup>) | O(1) | |
| 886 | Possible Bipartition | [C#](./LeetCode/0851-0900/0886-PossibleBipartition.cs)(296ms) | O(N+E) | O(N+E) | |
| 888 | Fair Candy Swap | [C#](./LeetCode/0851-0900/0888-FairCandySwap.cs)(308ms) | | | |
| 889 | Construct Binary Tree from Preorder and Postorder Traversal | [C#](./LeetCode/0851-0900/0889-ConstructBinaryTreeFromPreorderAndPostorderTraversal.cs)(100ms) | O(N<sup>2</sup>) | O(N) | |
| 890 | Find and Replace Pattern | [C#](./LeetCode/0851-0900/0890-FindAndReplacePattern.cs)(240ms) | O(N*M) | O(N) | |
| 892 | Surface Area of 3D Shapes | [C#](./LeetCode/0851-0900/0892-SurfaceAreaOf3DShapes.cs)(92ms) | O(N<sup>2</sup>) | O(N) | Same as [883: Projection Area of 3D Shapes](./Problems/0851-0900/0883-ProjectionAreaOf3DShapes.md) |
| 894 | All Possible Full Binary Trees | [C#](./LeetCode/0851-0900/0894-AllPossibleFullBinaryTrees.cs)(256ms) | O(2<sup>N</sup>) | O(2<sup>N</sup>) | |
| 895 | Maximum Frequency Stack | [C#](./LeetCode/0851-0900/0895-MaximumFrequencyStack.cs)(372ms) | O(1) | O(N) | |
| 896 | Monotonic Array | [C#](./LeetCode/0851-0900/0896-MonotonicArray.cs)(160ms) | O(N) | O(1) | |
| 897 | Increasing Order Search Tree | [C#](./LeetCode/0851-0900/0897-IncreasingOrderSearchTree.cs)(84ms) | O(N) | O(H) | |

### Problems 901-950
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 901 | Online Stock Span | [C#](./LeetCode/0901-0950/0901-OnlineStockSpan.cs)(448ms) | O(N) | O(N) | |
| 904 | Fruit Into Baskets | [C#](./LeetCode/0901-0950/0904-FruitIntoBaskets.cs)(212ms) | O(N) | O(1) | |
| 905 | Sort Array By Parity | [C#](./LeetCode/0901-0950/0905-SortArrayByParity.cs)(244ms) | O(N) | O(1) | |
| 908 | Smallest Range I | [C#](./LeetCode/0901-0950/0908-SmallestRangeI.cs)(108ms) | O(N) | O(1) | |
| 912 | Sort an Array | [C#](./LeetCode/0901-0950/0912-SortAnArray.cs)(268ms) | | | |
| 913 | Cat and Mouse | [C#](./LeetCode/0901-0950/0913-CatAndMouse.cs)(116ms) | O(N<sup>3</sup>) | O(N<sup>2</sup>) | |
| 914 | X of a Kind in a Deck of Cards | [C#](./LeetCode/0901-0950/0914-XOfAKindInADeckOfCards.cs)(96ms) | O(NlogN) | O(N) | |
| 917 | Reverse Only Letters | [C#](./LeetCode/0901-0950/0917-ReverseOnlyLetters.cs)(76ms) | O(N) | O(N) | |
| 918 | Maximum Sum Circular Subarray | [C#](./LeetCode/0901-0950/0918-MaximumSumCircularSubarray.cs)(152ms) | O(N) | O(1) | |
| 921 | Minimum Add to Make Parentheses Valid | [C#](./LeetCode/0901-0950/0921-MinimumAddToMakeParenthesesValid.cs)(72ms) | O(N) | O(1) | |
| 922 | Sort Array By Parity II | [C#](./LeetCode/0901-0950/0922-SortArrayByParityII.cs)(272ms) | O(N) | O(1) | |
| 925 | Long Pressed Name | [C#](./LeetCode/0901-0950/0925-LongPressedName.cs)(72ms) | O(N+M) | O(1) | |
| 929 | Unique Email Addresses | [C#](./LeetCode/0901-0950/0929-UniqueEmailAddresses.cs)(108ms) | O(N) | O(N) | |
| 931 | Minimum Falling Path Sum | [C#](./LeetCode/0901-0950/0931-MinimumFallingPathSum.cs)(100ms) | O(N*N) | O(N*N) | |
| 933 | Number of Recent Calls | [C#](./LeetCode/0901-0950/0933-NumberOfRecentCalls.cs)(276ms) | O(1) | O(N) | |
| 937 | Reorder Data in Log Files | [C#](./LeetCode/0901-0950/0937-ReorderDataInLogFiles.cs)(256ms) | O(NLogN) | O(N) | `Array.Sort` is not stable. `System.Linq` is slow |
| 938 | Range Sum of BST | [C#](./LeetCode/0901-0950/0938-RangeSumOfBST.cs)(172ms) | O(N) | O(1) | |
| 939 | Minimum Area Rectangle | [C#](./LeetCode/0901-0950/0939-MinimumAreaRectangle.cs)(352ms) | O(N<sup>2</sup>) | O(N) | |
| 941 | Valid Mountain Array | [C#](./LeetCode/0901-0950/0941-ValidMountainArray.cs)(116ms) | O(N) | O(1) | |
| 942 | DI String Match | [C#](./LeetCode/0901-0950/0942-DIStringMatch.cs)(224ms) | O(N) | O(N) | |
| 944 | Delete Columns to Make Sorted | [C#](./LeetCode/0901-0950/0944-DeleteColumnsToMakeSorted.cs)(96ms) | O(N*M) | O(1) | |
| 946 | Validate Stack Sequences | [C#](./LeetCode/0901-0950/0946-ValidateStackSequences.cs)(92ms) | O(N) | O(N) | |
| 947 | Most Stones Removed with Same Row or Column | [C#](./LeetCode/0901-0950/0947-MostStonesRemovedWithSameRoworColumn.cs)(140ms) | O(NlogN) | O(N) | |
| 949 | Largest Time for Given Digits | [C#](./LeetCode/0901-0950/0949-LargestTimeForGivenDigits.cs)(104ms) | O(1) | O(1) | |
| 950 | Reveal Cards In Increasing Order | [C#](./LeetCode/0901-0950/0950-RevealCardsInIncreasingOrder.cs)(240ms) | O(NlogN) | O(N) | |

### Problems 951-1000
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 951 | Flip Equivalent Binary Trees | [C#](./LeetCode/0951-1000/0951-FlipEquivalentBinaryTrees.cs)(108ms) | O(N) | O(logN) | |
| 952 | Largest Component Size by Common Factor | [C#](./LeetCode/0951-1000/0952-LargestComponentSizeByCommonFactor.cs)(276ms) | O(NlogN) | O(N) | |
| 953 | Verifying an Alien Dictionary | [C#](./LeetCode/0951-1000/0953-VerifyingAnAlienDictionary.cs)(88ms) | O(N) | O(1) | |
| 957 | Prison Cells After N Days | [C#](./LeetCode/0951-1000/0957-PrisonCellsAfterNDays.cs)(244ms) | O(N*M) | O(2<sup>M</sup>) | |
| 959 | Regions Cut By Slashes | [C#](./LeetCode/0951-1000/0959-RegionsCutBySlashes.cs)(92ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 961 | N-Repeated Element in Size 2N Array | [C#](./LeetCode/0951-1000/0961-NRepeatedElementInSize2NArray.cs)(124ms) | O(N) | O(N) | |
| 965 | Univalued Binary Tree | [C#](./LeetCode/0951-1000/0965-UnivaluedBinaryTree.cs)(92ms) | O(N) | O(1) | |
| 967 | Numbers With Same Consecutive Differences | [C#](./LeetCode/0951-1000/0967-NumbersWithSameConsecutiveDifferences.cs)(208ms) | O(N*2<sup>2</sup>) | O(2<sup>2</sup>) | |
| 969 | Pancake Sorting | [C#](./LeetCode/0951-1000/0969-PancakeSorting.cs)(244ms) | O(N<sup>2</sup>) | O(1) | |
| 970 | Powerful Integers | [C#](./LeetCode/0951-1000/0970-PowerfulIntegers.cs)(200ms) | O(log<sup>2</sup> bound) | O(log<sup>2</sup> bound) | |
| 973 | K Closest Points to Origin | [C#](./LeetCode/0951-1000/0973-KClosestPointsToOrigin.cs)(424ms) | O(N) | O(K) | |
| 975 | Odd Even Jump | [C#](./LeetCode/0951-1000/0975-OddEvenJump.cs)(204ms) | O(NlogN) | O(N) | |
| 976 | Largest Perimeter Triangle | [C#](./LeetCode/0951-1000/0976-LargestPerimeterTriangle.cs)(128ms) | O(NlogN) | O(1) | |
| 977 | Squares of a Sorted Array | [C#](./LeetCode/0951-1000/0977-SquaresOfASortedArray.cs)(284ms) | O(N) | O(N) | |
| 979 | Distribute Coins in Binary Tree | [C#](./LeetCode/0951-1000/0979-DistributeCoinsInBinaryTree.cs)(92ms) | O(N) | O(h) | |
| 980 | Unique Paths III | [C#](./LeetCode/0951-1000/0980-UniquePathsIII.cs)(92ms) | O(3<sup>N</sup>) | O(N) | |
| 981 | Time Based Key-Value Store | [C#](./LeetCode/0951-1000/0981-TimeBasedKeyValueStore.cs)(920ms) | O(LogN) | O(N) | |
| 983 | Minimum Cost For Tickets | [C#](./LeetCode/0951-1000/0983-MinimumCostForTickets.cs)(84ms) | O(N) | O(N) | |
| 985 | Sum of Even Numbers After Queries | [C#](./LeetCode/0951-1000/0985-SumOfEvenNumbersAfterQueries.cs)(372ms) | O(N) | O(1) | |
| 986 | Interval List Intersections | [C#](./LeetCode/0951-1000/0986-IntervalListIntersections.cs)(268ms) | O(N) | O(1) | |
| 987 | Vertical Order Traversal of a Binary Tree | [C#](./LeetCode/0951-1000/0987-VerticalOrderTraversalOfABinaryTree.cs)(240ms) | O(Nlog(N/k)) | O(N) | |
| 989 | Add to Array-Form of Integer | [C#](./LeetCode/0951-1000/0989-AddToArrayFormOfInteger.cs)(284ms) | O(N) | O(1) | |
| 993 | Cousins in Binary Tree | [C#](./LeetCode/0951-1000/0993-CousinsInBinaryTree.cs)(84ms) | O(N) | O(N) | |
| 994 | Rotting Oranges | [C#](./LeetCode/0951-1000/0994-RottingOranges.cs)(88ms) | O(N) | O(N) | |
| 997 | Find the Town Judge | [C#](./LeetCode/0951-1000/0997-FindTheTownJudge.cs)(292ms) | O(N) | O(N) | |
| 998 | Maximum Binary Tree II | [C#](./LeetCode/0951-1000/0998-MaximumBinaryTreeII.cs)(92ms) | O(H) | O(1) | |
| 999 | Available Captures for Rook | [C#](./LeetCode/0951-1000/0999-AvailableCapturesForRook.cs)(88ms) | O(N+M) | O(1) | |

### Problems 1001-1050
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1002 | Find Common Characters | [C#](./LeetCode/1001-1050/1002-FindCommonCharacters.cs)(232ms) | O(N) | O(1) | |
| 1005 | Maximize Sum Of Array After K Negations | [C#](./LeetCode/1001-1050/1005-MaximizeSumOfArrayAfterKNegations.cs)(96ms) | O(NlogN) | O(1) | |
| 1007 | Minimum Domino Rotations For Equal Row | [C#](./LeetCode/1001-1050/1007-MinimumDominoRotationsForEqualRow.cs)(264ms) | O(N) | O(1) | |
| 1008 | Construct Binary Search Tree from Preorder Traversal | [C#](./LeetCode/1001-1050/1008-ConstructBinarySearchTreeFromPreorderTraversal.cs)(88ms) | O(N) | O(N) | |
| 1009 | Complement of Base 10 Integer | [C#](./LeetCode/1001-1050/1009-ComplementOfBase10Integer.cs)(32ms) | O(1) | O(1) | |
| 1010 | Pairs of Songs With Total Durations Divisible by 60 | [C#](./LeetCode/1001-1050/1010-PairsOfSongsWithTotalDurationsDivisibleBy60.cs)(124ms) | O(N) | O(N) | |
| 1011 | Capacity To Ship Packages Within D Days | [C#](./LeetCode/1001-1050/1011-CapacityToShipPackagesWithinDDays.cs)(148ms) | O(LogN) | O(1) | Binary Search |
| 1013 | Partition Array Into Three Parts With Equal Sum | [C#](./LeetCode/1001-1050/1013-PartitionArrayIntoThreePartsWithEqualSum.cs)(140ms) | O(N) | O(1) | |
| 1018 | Binary Prefix Divisible By 5 | [C#](./LeetCode/1001-1050/1018-BinaryPrefixDivisibleBy5.cs)(256ms) | O(N) | O(1) | |
| 1021 | Remove Outermost Parentheses | [C#](./LeetCode/1001-1050/1021-RemoveOutermostParentheses.cs)(80ms) | O(N) | O(N) | |
| 1022 | Sum of Root To Leaf Binary Numbers | [C#](./LeetCode/1001-1050/1022-SumOfRootToLeafBinaryNumbers.cs)(92ms) | O(N) | O(N) | |
| 1024 | Video Stitching | [C#](./LeetCode/1001-1050/1024-VideoStitching.cs)(88ms) | O(NlogN) | O(1) | |
| 1025 | Divisor Game | [C#](./LeetCode/1001-1050/1025-DivisorGame.cs)(40ms) | O(N^2) | O(N) | |
| 1026 | Maximum Difference Between Node and Ancestor | [C#](./LeetCode/1001-1050/1026-MaximumDifferenceBetweenNodeAndAncestor.cs)(116ms) | O(N) | O(logN) | |
| 1029 | Two City Scheduling | [C#](./LeetCode/1001-1050/1029-TwoCityScheduling.cs)(88ms) | O(NlogN) | O(1) | |
| 1030 | Matrix Cells in Distance Order | [C#](./LeetCode/1001-1050/1030-MatrixCellsInDistanceOrder.cs)(256ms) | O(N*M) | O(N*M) | |
| 1032 | Stream of Characters | [C#](./LeetCode/1001-1050/1032-StreamOfCharacters.cs)(628ms) | O(M) | O(N) | |
| 1033 | Moving Stones Until Consecutive | [C#](./LeetCode/1001-1050/1033-MovingStonesUntilConsecutive.cs)(200ms) | O(1) | O(1) | |
| 1035 | Uncrossed Lines | [C#](./LeetCode/1001-1050/1035-UncrossedLines.cs)(84ms) | O(N+M) | O(N+M) | |
| 1037 | Valid Boomerang | [C#](./LeetCode/1001-1050/1037-ValidBoomerang.cs)(88ms) | O(1) | O(1) | |
| 1038 | Binary Search Tree to Greater Sum Tree | [C#](./LeetCode/1001-1050/1038-BinarySearchTreeToGreaterSumTree.cs)(88ms) | O(N) | O(N) | |
| 1041 | Robot Bounded In Circle | [C#](./LeetCode/1001-1050/1041-RobotBoundedInCircle.cs)(68ms) | O(N) | O(1) | |
| 1042 | Flower Planting With No Adjacent | [C#](./LeetCode/1001-1050/1042-FlowerPlantingWithNoAdjacent.cs)(384ms) | O(N) | O(N) | |
| 1043 | Partition Array for Maximum Sum | [C#](./LeetCode/1001-1050/1043-PartitionArrayForMaximumSum.cs)(96ms) | O(KN) | O(N) | |
| 1044 | Longest Duplicate Substring | [C#](./LeetCode/1001-1050/1044-LongestDuplicateSubstring.cs)(376ms) | O(NlogN) | O(N) | |
| 1046 | Last Stone Weight | [C#](./LeetCode/1001-1050/1046-LastStoneWeight.cs)(88ms) | O(N) | O(1) | |
| 1047 | Remove All Adjacent Duplicates In String | [C#](./LeetCode/1001-1050/1047-RemoveAllAdjacentDuplicatesInString.cs)(92ms) | O(N) | O(N) | |
| 1048 | Longest String Chain | [C#](./LeetCode/1001-1050/1048-LongestStringChain.cs)(216ms) | O(N*M) | O(N) | |

### Problems 1051-1100
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1051 | Height Checker | [C#](./LeetCode/1051-1100/1051-HeightChecker.cs)(88ms) | O(NlogN) | O(N) | |
| 1055 | Shortest Way to Form String | [C#](./LeetCode/1051-1100/1055-ShortestWaytoFormString.cs)(76ms) | O(N+M) | O(1) | |
| 1056 | Confusing Number | [C#](./LeetCode/1051-1100/1056-ConfusingNumber.cs)(36ms) | O(log<sub>10</sub> N) | O(1) | |
| 1057 | Campus Bikes | [C#](./LeetCode/1051-1100/1057-CampusBikes.cs)(452ms) | O(N*M) | O(N*M) | |
| 1061 | Lexicographically Smallest Equivalent String | [C#](./LeetCode/1051-1100/1061-LexicographicallySmallestEquivalentString.cs)(120ms) | O(N) | O(N) | |
| 1062 | Longest Repeating Substring | [C#](./LeetCode/1051-1100/1062-LongestRepeatingSubstring.cs)(80ms) | O(NlogN) | O(N) | |
| 1064 | Fixed Point | [C#](./LeetCode/1051-1100/1064-FixedPoint.cs)(92ms) | O(logN) | O(1) | |
| 1065 | Index Pairs of a String | [C#](./LeetCode/1051-1100/1065-IndexPairsOfAString.cs)(240ms) | O(N<sup>2</sup>) | O(N) | |
| 1066 | Campus Bikes II | [C#](./LeetCode/1051-1100/1066-CampusBikesII.cs)(96ms) | O(N*M) | O(N*M) | |
| 1071 | Greatest Common Divisor of Strings | [C#](./LeetCode/1051-1100/1071-GreatestCommonDivisorOfStrings.cs)(84ms) | O(N<sup>2</sup>) | O(N) | |
| 1072 | Flip Columns For Maximum Number of Equal Rows | [C#](./LeetCode/1051-1100/1072-FlipColumnsForMaximumNumberOfEqualRows.cs)(740ms) | O(N*M) | O(N*M) | |
| 1078 | Occurrences After Bigram | [C#](./LeetCode/1051-1100/1078-OccurrencesAfterBigram.cs)(232ms) | O(N) | O(N) | |
| 1079 | Letter Tile Possibilities | [C#](./LeetCode/1051-1100/1079-LetterTilePossibilities.cs)(68ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 1081 | Smallest Subsequence of Distinct Characters | [C#](./LeetCode/1051-1100/1081-SmallestSubsequenceOfDistinctCharacters.cs)(84ms) | O(N) | O(N) | |
| 1085 | Sum of Digits in the Minimum Number | [C#](./LeetCode/1051-1100/1085-SumOfDigitsInTheMinimumNumber.cs)(72ms) | | | |
| 1086 | High Five | [C#](./LeetCode/1051-1100/1086-HighFive.cs)(236ms) | O(NlogN) | O(N) | |
| 1087 | Brace Expansion | [C#](./LeetCode/1051-1100/1087-BraceExpansion.cs)(284ms) | O(N<sup>2</sup>) | O(N) | |
| 1089 | Duplicate Zeros | [C#](./LeetCode/1051-1100/1089-DuplicateZeros.cs)(248ms) | O(N) | O(1) | |
| 1094 | Car Pooling | [C#](./LeetCode/1051-1100/1094-CarPooling.cs)(100ms) | O(1) | O(1) | |
| 1096 | Brace Expansion II | [C#](./LeetCode/1051-1100/1096-BraceExpansionII.cs)(308ms) | O(N) | ? | |
| 1099 | Two Sum Less Than K | [C#](./LeetCode/1051-1100/1099-TwoSumLessThanK.cs)(88ms) | O(NlogN) | O(1) | |
| 1100 | Find K-Length Substrings With No Repeated Characters | [C#](./LeetCode/1051-1100/1100-FindKLengthSubstringsWithNoRepeatedCharacters.cs)(80ms) | O(N) | O(K) | |

### Problems 1101-1150
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1101 | The Earliest Moment When Everyone Become Friends | [C#](./LeetCode/1101-1150/1101-TheEarliestMomentWhenEveryoneBecomeFriends.cs)(144ms) | O(NlogN) | O(N) | |
| 1102 | Path With Maximum Minimum Value | [C#](./LeetCode/1101-1150/1102-PathWithMaximumMinimumValue.cs)(344ms) | O(N*M log N*M ) | O(N*M) | |
| 1103 | Distribute Candies to People | [C#](./LeetCode/1101-1150/1103-DistributeCandiesToPeople.cs)(196ms) | O(N) | O(N) | |
| 1104 | Path In Zigzag Labelled Binary Tree | [C#](./LeetCode/1101-1150/1104-PathInZigzagLabelledBinaryTree.cs)(200ms) | O(logN) | O(1) | |
| 1108 | Defanging an IP Address | [C#](./LeetCode/1101-1150/1108-DefangingAnIPAddress.cs)(80ms) | O(N) | O(N) | |
| 1110 | Delete Nodes And Return Forest | [C#](./LeetCode/1101-1150/1110-DeleteNodesAndReturnForest.cs)(252ms) | | | |
| 1111 | Maximum Nesting Depth of Two Valid Parentheses Strings | [C#](./LeetCode/1101-1150/1111-MaximumNestingDepthOfTwoValidParenthesesStrings.cs)(232ms) | O(N) | O(1) | |
| 1114 | Print in Order | [C#](./LeetCode/1101-1150/1114-PrintInOrder.cs)(112ms) | | | |
| 1118 | Number of Days in a Month | [C#](./LeetCode/1101-1150/1118-NumberOfDaysInAMonth.cs)(36ms) | O(1) | O(1) | |
| 1119 | Remove Vowels from a String | [C#](./LeetCode/1101-1150/1119-RemoveVowelsFromAString.cs)(80ms) | O(N) | O(N) | |
| 1120 | Maximum Average Subtree | [C#](./LeetCode/1101-1150/1120-MaximumAverageSubtree.cs)(104ms) | O(N) | O(N) | |
| 1122 | Relative Sort Array | [C#](./LeetCode/1101-1150/1122-RelativeSortArray.cs)(236ms) | O(N) | O(N) | |
| 1123 | Lowest Common Ancestor of Deepest Leaves | [C#](./LeetCode/1101-1150/1123-LowestCommonAncestorOfDeepestLeaves.cs)(104ms) | O(N) | O(logN) | |
| 1128 | Number of Equivalent Domino Pairs | [C#](./LeetCode/1101-1150/1128-NumberOfEquivalentDominoPairs.cs)(148ms) | O(N) | O(N) | |
| 1130 | Minimum Cost Tree From Leaf Values | [C#](./LeetCode/1101-1150/1130-MinimumCostTreeFromLeafValues.cs)(108ms) | O(N) | O(N) | |
| 1133 | Largest Unique Number | [C#](./LeetCode/1101-1150/1133-LargestUniqueNumber.cs)(92ms) | O(N) | O(1) | |
| 1134 | Armstrong Number | [C#](./LeetCode/1101-1150/1134-ArmstrongNumber.cs)(36ms) | O(N) | O(1) | |
| 1137 | N-th Tribonacci Number | [C#](./LeetCode/1101-1150/1137-NThTribonacciNumber.cs)(36ms) | O(N) | O(1) | |
| 1140 | Stone Game II | [C#](./LeetCode/1101-1150/1140-StoneGameII.cs)(92ms) | | | |
| 1143 | Longest Common Subsequence | [C#](./LeetCode/1101-1150/1143-LongestCommonSubsequence.cs)(68ms) | O(M*N) | O(Min(M, N)) | |
| 1150 | Check If a Number Is Majority Element in a Sorted Array | [C#](./LeetCode/1101-1150/1150-CheckIfANumberIsMajorityElementInASortedArray.cs)(84ms) | O(N) | O(1) | |

### Problems 1151-1200
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1152 | Analyze User Website Visit Pattern | [C#](./LeetCode/1151-1200/1152-AnalyzeUserWebsiteVisitPattern.cs)(304ms) | O(N<sup>2<sup>) | O(N) | |
| 1154 | Day of the Year | [C#](./LeetCode/1151-1200/1154-DayOfTheYear.cs)(80ms) | O(1) | O(1) | |
| 1160 | Find Words That Can Be Formed by Characters | [C#](./LeetCode/1151-1200/1160-FindWordsThatCanBeFormedByCharacters.cs)(108ms) | O(N) | O(1) | |
| 1161 | Maximum Level Sum of a Binary Tree | [C#](./LeetCode/1151-1200/1161-MaximumLevelSumOfABinaryTree.cs)(212ms) | O(N) | O(logN) | |
| 1165 | Single-Row Keyboard | [C#](./LeetCode/1151-1200/1165-SingleRowKeyboard.cs)(76ms) | O(N) | O(1) | |
| 1167 | Minimum Cost to Connect Sticks | [C#](./LeetCode/1151-1200/1167-MinimumCostToConnectSticks.cs)(372ms) | O(N) | O(N) | |
| 1170 | Compare Strings by Frequency of the Smallest Character | [C#](./LeetCode/1151-1200/1170-CompareStringsByFrequencyOfTheSmallestCharacter.cs)(244ms) | O(N) | O(1) | |
| 1175 | Prime Arrangements | [C#](./LeetCode/1151-1200/1175-PrimeArrangements.cs)(36ms) | O(N) | O(1) | |
| 1176 | Diet Plan Performance | [C#](./LeetCode/1151-1200/1176-DietPlanPerformance.cs)(116ms) | O(N) | O(1) | |
| 1180 | Count Substrings with Only One Distinct Letter | [C#](./LeetCode/1151-1200/1180-CountSubstringsWithOnlyOneDistinctLetter.cs)(72ms) | O(N) | O(1) | |
| 1184 | Distance Between Bus Stops | [C#](./LeetCode/1151-1200/1184-DistanceBetweenBusStops.cs)(92ms) | O(N) | O(1) | |
| 1185 | Day of the Week | [C#](./LeetCode/1151-1200/1185-DayOfTheWeek.cs)(80ms) | O(1) | O(1) | |
| 1189 | Maximum Number of Balloons | [C#](./LeetCode/1151-1200/1189-MaximumNumberOfBalloons.cs)(68ms) | O(N) | O(1) | |
| 1190 | Reverse Substrings Between Each Pair of Parentheses | [C#](./LeetCode/1151-1200/1190-ReverseSubstringsBetweenEachPairOfParentheses.cs)(88ms) | O(N) | O(N) | |
| 1192 | Critical Connections in a Network | [C#](./LeetCode/1151-1200/1192-CriticalConnectionsInANetwork.cs)(992ms) | O(E) | O(E) | |
| 1196 | How Many Apples Can You Put into the Basket | [C#](./LeetCode/1151-1200/1196-HowManyApplesCanYouPutIntoTheBasket.cs)(88ms) | O(NlogN) | O(1) | |
| 1197 | Minimum Knight Moves | [C#](./LeetCode/1151-1200/1197-MinimumKnightMoves.cs)(44ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 1198 | Find Smallest Common Element in All Rows | [C#](./LeetCode/1151-1200/1198-FindSmallestCommonElementInAllRows.cs)(168ms) | O(N*M) | O(N) | |
| 1200 | Minimum Absolute Difference | [C#](./LeetCode/1151-1200/1200-MinimumAbsoluteDifference.cs)(328ms) | O(N) | O(N) | |

### Problems 1201-1250
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1207 | Unique Number of Occurrences | [C#](./LeetCode/1201-1250/1207-UniqueNumberOfOccurrences.cs)(84ms) | O(N) | O(N) | |
| 1213 | Intersection of Three Sorted Arrays | [C#](./LeetCode/1201-1250/1213-IntersectionOfThreeSortedArrays.cs)(236ms) | O(N) | O(1) | |
| 1214 | Two Sum BSTs | [C#](./LeetCode/1201-1250/1214-TwoSumBsts.cs)(116ms) | O(N+M) | O(N+M) | |
| 1217 | Play with Chips | [C#](./LeetCode/1201-1250/1217-PlayWithChips.cs)(84ms) | O(N) | O(1) | |
| 1219 | Path with Maximum Gold | [C#](./LeetCode/1201-1250/1219-PathWithMaximumGold.cs)(112ms) | O(N*M) | O(N*M) | |
| 1221 | Split a String in Balanced Strings | [C#](./LeetCode/1201-1250/1221-SplitAStringInBalancedStrings.cs)(68ms) | O(N) | O(1) | |
| 1222 | Queens That Can Attack the King | [C#](./LeetCode/1201-1250/1222-QueensThatCanAttackTheKing.cs)(288ms) | O(1) | O(1) | |
| 1227 | Airplane Seat Assignment Probability | [C#](./LeetCode/1201-1250/1227-AirplaneSeatAssignmentProbability.cs)(44ms) | O(1) | O(1) | |
| 1228 | Missing Number In Arithmetic Progression | [C#](./LeetCode/1201-1250/1228-MissingNumberInArithmeticProgression.cs)(88ms) | O(logN) | O(1) | |
| 1229 | Meeting Scheduler | [C#](./LeetCode/1201-1250/1229-MeetingScheduler.cs)(416ms) | O(N) | O(1) | |
| 1232 | Check If It Is a Straight Line | [C#](./LeetCode/1201-1250/1232-CheckIfItIsAStraightLine.cs)(92ms) | O(N) | O(1) | |
| 1235 | Maximum Profit in Job Scheduling | [C#](./LeetCode/1201-1250/1235-MaximumProfitInJobScheduling.cs)(576ms) | O(NlogN) | O(N) | |
| 1236 | Web Crawler | [C#](./LeetCode/1201-1250/1236-WebCrawler.cs)(332ms) | O(NE) | O(N) | |
| 1237 | Find Positive Integer Solution for a Given Equation | [C#](./LeetCode/1201-1250/1237-FindPositiveIntegerSolutionForAGivenEquation.cs)(196ms) | O(logM * logN)) | O(A) | |
| 1238 | Circular Permutation in Binary Representation | [C#](./LeetCode/1201-1250/1238-CircularPermutationInBinaryRepresentation.cs)(288ms) | O(N<sup>2</sup>) | O(N) | |
| 1242 | Web Crawler Multithreaded | [C#](./LeetCode/1201-1250/1242-WebCrawlerMultithreaded.cs)(368ms) | O(NE) | O(N) | |
| 1243 | Array Transformation | [C#](./LeetCode/1201-1250/1243-ArrayTransformation.cs)(220ms) | O(N) | O(1) | |
| 1245 | Tree Diameter | [C#](./LeetCode/1201-1250/1245-TreeDiameter.cs)(196ms) | O(N) | O(N) | |
| 1247 | Minimum Swaps to Make Strings Equal | [C#](./LeetCode/1201-1250/1247-MinimumSwapsToMakeStringsEqual.cs)(76ms) | O(N) | O(1) | |
| 1249 | Minimum Remove to Make Valid Parentheses | [C#](./LeetCode/1201-1250/1249-MinimumRemoveToMakeValidParentheses.cs)(96ms) | O(N) | O(N) | |

### Problems 1251-1300
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1252 | Cells with Odd Values in a Matrix | [C#](./LeetCode/1251-1300/1252-CellsWithOddValuesInAMatrix.cs)(84ms) | O(N*M) | O(N+M) | |
| 1254 | Number of Closed Islands | [C#](./LeetCode/1251-1300/1254-NumberOfClosedIslands.cs)(104ms) | O(N*M) | O(N*M) | |
| 1256 | Encode Number | [C#](./LeetCode/1251-1300/1256-EncodeNumber.cs)(96ms) | O(1) | O(1) | |
| 1258 | Synonymous Sentences | [C#](./LeetCode/1251-1300/1258-SynonymousSentences.cs)(284ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 1260 | Shift 2D Grid | [C#](./LeetCode/1251-1300/1260-Shift2DGrid.cs)(272ms) | O(N*M) | O(N*M) | |
| 1261 | Find Elements in a Contaminated Binary Tree | [C#](./LeetCode/1251-1300/1261-FindElementsInAContaminatedBinaryTree.cs)(156ms) | O(1) | O(N) | |
| 1265 | Print Immutable Linked List in Reverse | [C#](./LeetCode/1251-1300/1265-PrintImmutableLinkedListInReverse.cs) | O(N) | O(1) | |
| 1266 | Minimum Time Visiting All Points | [C#](./LeetCode/1251-1300/1266-MinimumTimeVisitingAllPoints.cs)(80ms) | O(N) | O(1) | |
| 1268 | Search Suggestions System | [C#](./LeetCode/1251-1300/1268-SearchSuggestionsSystem.cs)(360ms) | O(N*M) | O(N*M) | |
| 1271 | Hexspeak | [C#](./LeetCode/1251-1300/1271-Hexspeak.cs)(84ms) | O(logN) | O(1) | |
| 1273 | Delete Tree Nodes | [C#](./LeetCode/1251-1300/1273-DeleteTreeNodes.cs)(152ms) | O(N) | O(N) | |
| 1275 | Find Winner on a Tic Tac Toe Game | [C#](./LeetCode/1251-1300/1275-FindWinnerOnATicTacToeGame.cs)(100ms) | O(N) | O(1) | |
| 1277 | Count Square Submatrices with All Ones | [C#](./LeetCode/1251-1300/1277-CountSquareSubmatricesWithAllOnes.cs)(164ms) | O(N*M) | O(N*M) | |
| 1279 | Traffic Light Controlled Intersection | [C#](./LeetCode/1251-1300/1279-TrafficLightControlledIntersection.cs)(248ms) | | | |
| 1281 | Subtract the Product and Sum of Digits of an Integer | [C#](./LeetCode/1251-1300/1281-SubtractTheProductAndSumOfDigitsOfAnInteger.cs)(32ms) | O(N) | O(1) | |
| 1282 | Group the People Given the Group Size They Belong To | [C#](./LeetCode/1251-1300/1282-GroupThePeopleGivenTheGroupSizeTheyBelongTo.cs)(252ms) | O(N) | O(N) | |
| 1286 | Iterator for Combination | [C#](./LeetCode/1251-1300/1286-IteratorForCombination.cs)(120ms) | O(K) | O(K) | |
| 1287 | Element Appearing More Than 25% In Sorted Array | [C#](./LeetCode/1251-1300/1287-ElementAppearingMoreThan25InSortedArray.cs)(96ms) | O(N) | O(1) | |
| 1288 | Remove Covered Intervals | [C#](./LeetCode/1251-1300/1288-RemoveCoveredIntervals.cs)(100ms) | O(NlogN) | O(N) | |
| 1290 | Convert Binary Number in a Linked List to Integer | [C#](./LeetCode/1251-1300/1290-ConvertBinaryNumberInALinkedListToInteger.cs)(84ms) | O(N) | O(1) | |
| 1291 | Sequential Digits | [C#](./LeetCode/1251-1300/1291-SequentialDigits.cs)(204ms) | O(1) | O(1) | |
| 1295 | Find Numbers with Even Number of Digits | [C#](./LeetCode/1251-1300/1295-FindNumbersWithEvenNumberOfDigits.cs)(92ms) | O(N) | O(N) | |
| 1296 | Divide Array in Sets of K Consecutive Numbers | [C#](./LeetCode/1251-1300/1296-DivideArrayInSetsOfKConsecutiveNumbers.cs)(592ms) | O(NlogN) | O(N) | |
| 1299 | Replace Elements with Greatest Element on Right Side | [C#](./LeetCode/1251-1300/1299-ReplaceElementsWithGreatestElementOnRightSide.cs)(264ms) | O(N) | O(1) | |

### Problems 1301-1350
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1302 | Deepest Leaves Sum | [C#](./LeetCode/1301-1350/1302-DeepestLeavesSum.cs)(116ms) | O(N) | O(N) | |
| 1304 | Find N Unique Integers Sum up to Zero | [C#](./LeetCode/1301-1350/1304-FindNUniqueIntegersSumUpToZero.cs)(200ms) | O(logN) | O(N) | |
| 1305 | All Elements in Two Binary Search Trees | [C#](./LeetCode/1301-1350/1305-AllElementsInTwoBinarySearchTrees.cs)(360ms) | O(N+M) | O(N+M) | |
| 1306 | Jump Game III | [C#](./LeetCode/1301-1350/1306-JumpGameIII.cs)(116ms) | O(N) | O(N) | |
| 1309 | Decrypt String from Alphabet to Integer Mapping | [C#](./LeetCode/1301-1350/1309-DecryptStringFromAlphabetToIntegerMapping.cs)(76ms) | O(N) | O(N) | |
| 1310 | XOR Queries of a Subarray | [C#](./LeetCode/1301-1350/1310-XORQueriesOfASubarray.cs)(464ms) | O(N) | O(1) | |
| 1313 | Decompress Run-Length Encoded List | [C#](./LeetCode/1301-1350/1313-DecompressRunLengthEncodedList.cs)(236ms) | O(N) | O(N) | |
| 1314 | Matrix Block Sum | [C#](./LeetCode/1301-1350/1314-MatrixBlockSum.cs)(256ms) | O(N*M) | O(N*M) | |
| 1315 | Sum of Nodes with Even-Valued Grandparent | [C#](./LeetCode/1301-1350/1315-SumOfNodesWithEvenValuedGrandparent.cs)(112ms) | O(N) | O(1) | |
| 1317 | Convert Integer to the Sum of Two No-Zero Integers | [C#](./LeetCode/1301-1350/1317-ConvertIntegerToTheSumOfTwoNoZeroIntegers.cs)(196ms) | O(N) | O(1) | |
| 1318 | Minimum Flips to Make a OR b Equal to c | [C#](./LeetCode/1301-1350/1318-MinimumFlipsToMakeAORBEqualToC.cs)(40ms) | O(log(MAX(a,b,c))) | O(1) | |
| 1323 | Maximum 69 Numberr | [C#](./LeetCode/1301-1350/1323-Maximum69Numberr.cs)(40ms) | O(1) | O(1) | |
| 1325 | Delete Leaves With a Given Value | [C#](./LeetCode/1301-1350/1325-DeleteLeavesWithAGivenValue.cs)(100ms) | O(N) | O(logN) | |
| 1326 | Minimum Number of Taps to Open to Water a Garden | [C#](./LeetCode/1301-1350/1326-MinimumNumberOfTapsToOpenToWaterAGarden.cs)(104ms) | O(NlogN) | O(N) | |
| 1329 | Sort the Matrix Diagonally | [C#](./LeetCode/1301-1350/1329-SortTheMatrixDiagonally.cs) | O(N*N log Min(N, M)) | O(N*M) | |
| 1331 | Rank Transform of an Array | [C#](./LeetCode/1301-1350/1331-RankTransformOfAnArray.cs)(368ms) | O(NlogN) | O(N) | |
| 1332 | Remove Palindromic Subsequences | [C#](./LeetCode/1301-1350/1332-RemovePalindromicSubsequences.cs)(68ms) | O(N) | O(1) | |
| 1337 | The K Weakest Rows in a Matrix | [C#](./LeetCode/1301-1350/1337-TheKWeakestRowsInAMatrix.cs)(248ms) | O(M*N) | O(K) | |
| 1338 | Reduce Array Size to The Half | [C#](./LeetCode/1301-1350/1338-ReduceArraySizeToTheHalf.cs)(332ms) | O(NloN) | O(N) | |
| 1342 | Number of Steps to Reduce a Number to Zero | [C#](./LeetCode/1301-1350/1342-NumberOfStepsToReduceANumberToZero.cs)(40ms) | O(logN) | O(1) | |
| 1343 | Number of Sub-arrays of Size K and Average Greater than or Equal to Threshold | [C#](./LeetCode/1301-1350/1343-NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold.cs)(252ms) | O(N) | O(1) | |
| 1344 | Angle Between Hands of a Clock | [C#](./LeetCode/1301-1350/1344-AngleBetweenHandsOfAClock.cs)(48ms) | O(1) | O(1) | |
| 1346 | Check If N and Its Double Exist | [C#](./LeetCode/1301-1350/1346-CheckIfNAndItsDoubleExist.cs)(92ms) | O(N) | O(N) | |
| 1347 | Minimum Number of Steps to Make Two Strings Anagram | [C#](./LeetCode/1301-1350/1347-MinimumNumberOfStepsToMakeTwoStringsAnagram.cs)(92ms) | O(N) | O(N) | |

### Problems 1351-1400
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1351 | Count Negative Numbers in a Sorted Matrix | [C#](./LeetCode/1351-1400/1351-CountNegativeNumbersInASortedMatrix.cs)(100ms) | O(N+M) | O(1) | |
| 1353 | Maximum Number of Events That Can Be Attended | [C#](./LeetCode/1351-1400/1353-MaximumNumberOfEventsThatCanBeAttended.cs)(436ms) | O(NlogN) | O(N) | |
| 1356 | Sort Integers by The Number of 1 Bits | [C#](./LeetCode/1351-1400/1356-SortIntegersByTheNumberOf1Bits.cs)(248ms) | O(NlogN) | O(1) | Brian Kernighan's Algorithm |
| 1357 | Apply Discount Every n Orders | [C#](./LeetCode/1351-1400/1357-ApplyDiscountEveryNOrders.cs)(724ms) | O(N) | O(N) | |
| 1360 | Number of Days Between Two Dates | [C#](./LeetCode/1351-1400/1360-NumberOfDaysBetweenTwoDates.cs)(68ms) | O(1) | O(1) | |
| 1365 | How Many Numbers Are Smaller Than the Current Number | [C#](./LeetCode/1351-1400/1365-HowManyNumbersAreSmallerThanTheCurrentNumber.cs)(236ms) | O(N) | O(N) | Count Sort |
| 1370 | Increasing Decreasing String | [C#](./LeetCode/1351-1400/1370-IncreasingDecreasingString.cs)(88ms) | O(N) | O(1) | |
| 1374 | Generate a String With Characters That Have Odd Counts | [C#](./LeetCode/1351-1400/1374-GenerateAStringWithCharactersThatHaveOddCounts.cs)(72ms) | O(N) | O(N) | |
| 1375 | Bulb Switcher III | [C#](./LeetCode/1351-1400/1375-BulbSwitcherIII.cs)(164ms) | O(N) | O(1) | |
| 1379 | Find a Corresponding Node of a Binary Tree in a Clone of That Tree | [C#](./LeetCode/1351-1400/1379-FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree.cs)(332ms) | O(N) | O(1) | |
| 1380 | Lucky Numbers in a Matrix | [C#](./LeetCode/1351-1400/1380-LuckyNumbersInAMatrix.cs)(260ms) | O(N*M) | O(N+M) | |
| 1381 | Design a Stack With Increment Operation | [C#](./LeetCode/1351-1400/1381-DesignAStackWithIncrementOperation.cs)(152ms) | O(1) | O(N) | |
| 1382 | Balance a Binary Search Tree | [C#](./LeetCode/1351-1400/1382-BalanceABinarySearchTree.cs)(152ms) | O(N) | O(N) | |
| 1385 | Find the Distance Value Between Two Arrays | [C#](./LeetCode/1351-1400/1385-FindTheDistanceValueBetweenTwoArrays.cs)(96ms) | O(NlogN) | O(1) | |
| 1387 | Sort Integers by The Power Value | [C#](./LeetCode/1351-1400/1387-SortIntegersByThePowerValue.cs)(100ms) | O(N) | O(N) | |
| 1389 | Create Target Array in the Given Order | [C#](./LeetCode/1351-1400/1389-CreateTargetArrayInTheGivenOrder.cs)(228ms) | O(N^2) | O(N) | |
| 1394 | Find Lucky Integer in an Array | [C#](./LeetCode/1351-1400/1394-FindLuckyIntegerInAnArray.cs)(96ms) | O(N) | O(N) | |
| 1395 | Count Number of Teams | [C#](./LeetCode/1351-1400/1395-CountNumberOfTeams.cs)(92ms) | O(N<sup>2</sup>) | O(1) | |
| 1396 | Design Underground System | [C#](./LeetCode/1351-1400/1396-DesignUndergroundSystem.cs)(624ms) | O(1) | O(N) | |
| 1399 | Count Largest Group | [C#](./LeetCode/1351-1400/1399-CountLargestGroup.cs)(48ms) | O(N) | O(N) | |
| 1400 | Construct K Palindrome Strings | [C#](./LeetCode/1351-1400/1400-ConstructKPalindromeStrings.cs)(84ms) | O(N) | O(N) | |

### Problems 1401-1450
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1403 | Minimum Subsequence in Non-Increasing Order | [C#](./LeetCode/1401-1450/1403-MinimumSubsequenceInNonIncreasingOrder.cs)(244ms) | O(N) | O(1) | |
| 1408 | String Matching in an Array | [C#](./LeetCode/1401-1450/1408-StringMatchingInAnArray.cs)(244ms) | O(N<sup>2</sup>) | O(N) | |
| 1409 | Queries on a Permutation With Key | [C#](./LeetCode/1401-1450/1409-QueriesOnAPermutationWithKey.cs)(244ms) | O(N*M) | O(M) | |
| 1413 | Minimum Value to Get Positive Step by Step Sum | [C#](./LeetCode/1401-1450/1413-MinimumValueToGetPositiveStepByStepSum.cs)(88ms) | O(N) | O(1) | |
| 1414 | Find the Minimum Number of Fibonacci Numbers Whose Sum Is K | [C#](./LeetCode/1401-1450/1414-FindTheMinimumNumberOfFibonacciNumbersWhoseSumIsK.cs)(44ms) | O(N) | O(N) | |
| 1415 | The k-th Lexicographical String of All Happy Strings of Length n | [C#](./LeetCode/1401-1450/1415-TheKThLexicographicalStringOfAllHappyStringsOfLengthN.cs)(92ms) | O(3<sup?N</sup>) | O(3<sup?N</sup>) | |
| 1417 | Reformat The String | [C#](./LeetCode/1401-1450/1417-ReformatTheString.cs)(84ms) | O(N) | O(N) | |
| 1418 | Display Table of Food Orders in a Restaurant | [C#](./LeetCode/1401-1450/1418-DisplayTableOfFoodOrdersInARestaurant.cs)(700ms) | O(N) | O(N) | |
| 1422 | Maximum Score After Splitting a String | [C#](./LeetCode/1401-1450/1422-MaximumScoreAfterSplittingAString.cs)(64ms) | O(N) | O(N) | |
| 1426 | Counting Elements | [C#](./LeetCode/1401-1450/1426-CountingElements.cs)(100ms) | O(NlogN) | O(N) | |
| 1427 | Perform String Shifts | [C#](./LeetCode/1401-1450/1427-PerformStringShifts.cs)(96ms) | O(N) | O(1) | |
| 1428 | Leftmost Column with at Least a One | [C#](./LeetCode/1401-1450/1428-LeftmostColumnWithAtLeastAOne.cs)(96ms) | O(N+M) | O(1) | |
| 1429 | First Unique Number | [C#](./LeetCode/1401-1450/1429-FirstUniqueNumber.cs)(696ms) | O(1) | O(N) | |
| 1430 | Check If a String Is a Valid Sequence from Root to Leaves Path in a Binary Tree | [C#](./LeetCode/1401-1450/1430-CheckIfAStringIsAValidSequenceFromRootToLeavesPathInABinaryTree.cs)(132ms) | O(logN) | O(1) | |
| 1431 | Kids With the Greatest Number of Candies | [C#](./LeetCode/1401-1450/1431-KidsWithTheGreatestNumberOfCandies.cs)(400ms) | O(N) | O(N) | |
| 1433 | Check If a String Can Break Another String | [C#](./LeetCode/1401-1450/1433-CheckIfAStringCanBreakAnotherString.cs)(112ms) | O(N) | O(1) | |
| 1436 | Destination City | [C#](./LeetCode/1401-1450/1436-DestinationCity.cs)(108ms) | O(N) | O(N) | |
| 1437 | Check If All 1's Are at Least Length K Places Away | [C#](./LeetCode/1401-1450/1437-CheckIfAll1SAreAtLeastLengthKPlacesAway.cs)(168ms) | O(N) | O(1) | |
| 1441 | Build an Array With Stack Operations | [C#](./LeetCode/1401-1450/1441-BuildAnArrayWithStackOperations.cs)(384ms) | O(N) | O(N) | |
| 1442 | Count Triplets That Can Form Two Arrays of Equal XOR | [C#](./LeetCode/1401-1450/1442-CountTripletsThatCanFormTwoArraysOfEqualXOR.cs)(120ms) | O(N) | O(N) | |
| 1446 | Consecutive Characters | [C#](./LeetCode/1401-1450/1446-ConsecutiveCharacters.cs)(72ms) | O(N) | O(1) | |
| 1447 | Simplified Fractions | [C#](./LeetCode/1401-1450/1447-SimplifiedFractions.cs)(368ms) | O(N<sup>2</sup>logN) | O(1) | |
| 1448 | Count Good Nodes in Binary Tree | [C#](./LeetCode/1401-1450/1448-CountGoodNodesInBinaryTree.cs)(180ms) | O(N) | )(logN) | |
| 1450 | Number of Students Doing Homework at a Given Time | [C#](./LeetCode/1401-1450/1450-NumberOfStudentsDoingHomeworkAtAGivenTime.cs)(92ms) | O(N) | O(1) | |

### Problems 1451-1500
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1455 | Check If a Word Occurs As a Prefix of Any Word in a Sentence | [C#](./LeetCode/1451-1500/1455-CheckIfAWordOccursAsAPrefixOfAnyWordInASentence.cs)(64ms) | O(N+M) | O(M) | |
| 1457 | Pseudo-Palindromic Paths in a Binary Tree | [C#](./LeetCode/1451-1500/1457-PseudoPalindromicPathsInABinaryTree.cs)(196ms) | O(N) | O(logN) | |
| 1460 | Make Two Arrays Equal by Reversing Sub-arrays | [C#](./LeetCode/1451-1500/1460-MakeTwoArraysEqualByReversingSubArrays.cs)(100ms) | O(N) | O(N) | |
| 1464 | Maximum Product of Two Elements in an Array | [C#](./LeetCode/1451-1500/1464-MaximumProductOfTwoElementsInAnArray.cs)(92ms) | O(N) | O(1) | |
| 1466 | Reorder Routes to Make All Paths Lead to the City Zero | [C#](./LeetCode/1451-1500/1466-ReorderRoutesToMakeAllPathsLeadToTheCityZero.cs)(368ms) | O(N) | O(N) | |
| 1469 | Find All The Lonely Nodes | [C#](./LeetCode/1451-1500/1469-FindAllTheLonelyNodes.cs)(252ms) | O(N) | O(N) | |
| 1470 | Shuffle the Array | [C#](./LeetCode/1451-1500/1470-ShuffleTheArray.cs)(240ms) | O(N) | O(1) | |
| 1472 | Design Browser History | [C#](./LeetCode/1451-1500/1472-DesignBrowserHistory.cs)(320ms) | O(1) | O(N) | |
| 1474 | Delete N Nodes After M Nodes of a Linked List | [C#](./LeetCode/1451-1500/1474-DeleteNNodesAfterMNodesOfALinkedList.cs)(108ms) | O(N) | O(1) | |
| 1476 | Subrectangle Queries | [C#](./LeetCode/1451-1500/1476-SubrectangleQueries.cs)(180ms) | O(1) | O(N) | |
| 1480 | Running Sum of 1d Array | [C#](./LeetCode/1451-1500/1480-RunningSumOf1DArray.cs)(240ms) | O(N) | O(1) | |
| 1485 | Clone Binary Tree With Random Pointer | [C#](./LeetCode/1451-1500/1485-CloneBinaryTreeWithRandomPointer.cs)(252ms) | O(N) | O(N) | |
| 1486 | XOR Operation in an Array | [C#](./LeetCode/1451-1500/1486-XOROperationInAnArray.cs)(36ms) | O(N) | O(1) | |
| 1490 | Clone N-ary Tree | [C#](./LeetCode/1451-1500/1490-CloneNAryTree.cs)(420ms) | O(N) | O(N) | |
| 1491 | Average Salary Excluding the Minimum and Maximum Salary | [C#](./LeetCode/1451-1500/1491-AverageSalaryExcludingTheMinimumAndMaximumSalary.cs)(88ms) | O(N) | O(1) | |
| 1492 | The kth Factor of n | [C#](./LeetCode/1451-1500/1492-TheKthFactorOfN.cs)(40ms) | O(sqrt(N)) | O(1) | |
| 1496 | Path Crossing | [C#](./LeetCode/1451-1500/1496-PathCrossing.cs)(72ms) | O(N) | O(N) | |

### Problems 1501-1550
[Back to Table of Contents](#Table-of-Contents)

| # | Title | Solutions | Time | Space | Comments |
|---| ----- | --------- | ---- | ----- | -------- |
| 1502 | Can Make Arithmetic Progression From Sequence | [C#](./LeetCode/1501-1550/1502-CanMakeArithmeticProgressionFromSequence.cs)(92ms) | O(N) | O(1) | |
| 1504 | Count Submatrices With All Ones | [C#](./LeetCode/1501-1550/1504-CountSubmatricesWithAllOnes.cs)(116ms) | O(N*M) | O(N*M) | |
| 1506 | Find Root of N-Ary Tree | [C#](./LeetCode/1501-1550/1506-FindRootOfNAryTree.cs)(352ms) | O(N) | O(1) | |
| 1507 | Reformat Date | [C#](./LeetCode/1501-1550/1507-ReformatDate.cs)(88ms) | O(N) | O(N) | |
| 1508 | Range Sum of Sorted Subarray Sums | [C#](./LeetCode/1501-1550/1508-RangeSumOfSortedSubarraySums.cs)(388ms) | O(N<sup>2</sup>) | O(N<sup>2</sup>) | |
| 1512 | Number of Good Pairs | [C#](./LeetCode/1501-1550/1512-NumberOfGoodPairs.cs)(92ms) | O(N) | O(N) | |
| 1518 | Water Bottles | [C#](./LeetCode/1501-1550/1518-WaterBottles.cs)(32ms) | O(log<sub>k</sub>N) | O(1) | |
