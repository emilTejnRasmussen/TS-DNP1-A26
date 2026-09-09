

return;

bool CanFastAttack(bool knightIsAwake)
{
    return !knightIsAwake;
}

bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
{
    return knightIsAwake || archerIsAwake || prisonerIsAwake;
}

bool CanSignal(bool archerIsAwake, bool prisonerIsAwake)
{
    return !archerIsAwake && prisonerIsAwake;
}

bool CanFree(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool dogIsPresent)
{
    return (!knightIsAwake && !archerIsAwake && prisonerIsAwake)
           || (!archerIsAwake && dogIsPresent);
}