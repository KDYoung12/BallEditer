using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ÿ���� �Ӽ� (�� ����, �⺻, �μ��� �� �ִ�, ��ź, ����, ���� ����, ������ ����, �����̵�, ���� �ľǿ�)
public enum TileTypeOne { Empty = 0, Base, Broke, Boom, Jump, StraighLeft, StraightRight, Blink, LastIndex }

public class TileOne : MonoBehaviour
{
    [SerializeField]
    private Sprite[] images; // Ÿ�Ͽ� ����� �� �ִ� �̹��� �迭
    private SpriteRenderer spriteRenderer; // Ÿ�� �̹��� ������ ���� SpriteRenderer
    private TileTypeOne tileType; // ���� Ÿ���� �Ӽ�

    public void Setup(TileTypeOne tileType)
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        TileType = tileType;
    }

    public TileTypeOne TileType
    {
        set
        {
            tileType = value;
            spriteRenderer.sprite = images[(int)tileType - 1];
        }
        get => tileType;
    }
}
