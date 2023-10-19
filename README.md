## 张哲的实习任务交付

### 一、功能实现清单

1. **做出可控制可发射子弹的装甲车；**
   - [x] 英雄WASD或者方向键移动
   - [x] 子弹发射
   - [x] 弹道受重力影响
   - [ ] 子弹反弹
   - [x] 弹道散布，参考FPS游戏中的后坐力设定，短时间内连续发射，弹道向上飘。
   - [x] 规则模拟：枪口过热和冷却（为了便于演示，实际参数与原版规则略有不同，散热速率和发热速率都可以在面板中很方便地调整）
2. **实现哨兵运动与自动攻击玩家；**
   - [x] 哨兵直线往复运动
   - [x] 哨兵射线检测玩家，检测到玩家后停止移动
   - [x] 哨兵攻击玩家，玩家受到攻击扣血
3. **建模RMUL基地模型，并将导入Unity为其设置浮动血条；**
   - [x] 浮动血条
   - [x] 建模（有点丑陋，导入Unity后由于缺失材质，更加丑陋了）
4. **实现美观的UI；**
   - [x] 绘制准星，并根据第一人称和第三人称视角的偏差，绘制合适的、准确的准星
   - [x] 左上角显示当前枪口热量和血量
   - [x] 背景音乐与发射子弹音效，哨兵爆炸，基地爆炸音效
5. **实现完整的游戏逻辑；**
   - [x] F切换视角，G切换旁观者视角，R重新游戏
   - [x] 哨兵死亡前，基地无敌
   - [x] 基地血量随时间自动恢复，每五秒恢复一次；
